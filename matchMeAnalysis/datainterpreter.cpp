#include "datainterpreter.h"

#include <QDebug>
#include <QFile>
#include <QDateTime>

DataInterpreter::DataInterpreter(QQuickItem *comItem)
{
    _comItem = comItem;
}

DataInterpreter::~DataInterpreter()
{
    for(Event *e : _events)
        delete e;
}

void DataInterpreter::readFilesInFolder(QString folderPath)
{
    qDebug() << folderPath;

    for(int i = 1; QFile::exists(folderPath+QString("playerInfo")+QString::number(i)+QString(".csv")); i++){//iterate as long as the next file exists
        //reading file
        QString filepath = folderPath+QString("playerInfo")+QString::number(i)+QString(".csv");
        QFile file(filepath);
        if(!file.open(QIODevice::ReadOnly)) {
            qDebug() << "could not read file "+filepath+"!";
        }

        QTextStream inputStream(&file);
        while(!inputStream.atEnd()){
            QString rawEvent = inputStream.readLine();
            for(QString s : rawEvent.split(",")){
                if(!s.isEmpty()){
                    //get the raw strings
                    int userID = i;
                    QString rawTime = s.left(20).remove(",");//first 20 characters are date and time
                    QString rawType = s.split(":").last();
                    QString rawDescription = s.split(":").last();

                    //compute the raw strings to the actual data
                    QDateTime time = QDateTime::fromString(rawTime, "dd.MM.yyyy HH:mm:ss:");
                    EEventType type = EEventType::GAME_STARTED;
                    if(rawType.contains("active"))
                        type = EEventType::START_SESSION;
                    if(rawType.contains("inactive"))
                        type = EEventType::STOP_SESSION;
                    if(rawType.contains("openned"))
                        type = EEventType::OPEN_APP;
                    if(rawType.contains("closed"))
                        type = EEventType::CLOSE_APP;
                    if(rawType.contains("won"))
                        type = EEventType::GAME_WON;
                    if(rawType.contains("lost"))
                        type = EEventType::GAME_LOST;
                    if(rawType.contains("started"))
                        type = EEventType::GAME_STARTED;
                    QString description = rawDescription;//TODO: maybe just put the neccecary stuff here

                    //create and add the event
                    Event *e = new Event(userID, time, type, description);
                    _events.append(e);

                    qDebug() << e->getUserID() << e->getTime().toString() << e->getType() << e->getDescription();//TODO: delete

                }
            }
        }
    }
}

//this method should be calld after the readFilesInFolder
void DataInterpreter::fillOverview()
{
    //calculate the needed data
    int startCount = 0;
    int lostCount = 0;
    int wonCount = 0;
    for(Event *e : _events){
        if(e->getType() == EEventType::GAME_STARTED)
            startCount ++;
        if(e->getType() == EEventType::GAME_LOST)
            lostCount ++;
        if(e->getType() == EEventType::GAME_WON)
            wonCount ++;
    }

    //send the calculated data
    QVariant returnedValue;
    QMetaObject::invokeMethod(_comItem, "fillOverview",
            Q_RETURN_ARG(QVariant, returnedValue),
            Q_ARG(QVariant, QVariant(startCount)),
              Q_ARG(QVariant, QVariant(lostCount)),
              Q_ARG(QVariant, QVariant(wonCount)));
}


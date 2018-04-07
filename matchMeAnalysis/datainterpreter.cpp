#include "datainterpreter.h"

#include <QDebug>
#include <QFile>
#include <QDateTime>

DataInterpreter::DataInterpreter()
{

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
//            QDateTime time = QDateTime.fromString(rawEvent.left(19));//first 19 characters are the Date and Time
            qDebug() << rawEvent;
//            qDebug() << time;
        }
    }



    //old stuff
//        QList<DifferenceData> data;
//    //reading file A
//    QFile fileA(_fileA);
//    if(!fileA.open(QIODevice::ReadOnly)) {
//        qDebug() << "could not read file A!";
//    }
//    QTextStream inA(&fileA);

//    //reading file B
//    qDebug() << _fileB;
//    QFile fileB(_fileB);
//    if(!fileB.open(QIODevice::ReadOnly)) {
//        qDebug() << "could not read file B!";
//    }
//    QTextStream inB(&fileB);

//    //important for the data: delete the first three lines!
//    int linesToDelete = 3;
//    int count = 0;

//    QList<long long> diffsA;
//    QList<long long> diffsB;

//    while(!inA.atEnd() && !inB.atEnd()) {
//        count++;
//        QString lineA = inA.readLine();
//        QString lineB = inB.readLine();
//        if(count > linesToDelete){


//            QStringList fieldsA = lineA.split(".");
//            long long dataAint = fieldsA.first().split(" ")[0].toLongLong();
//            long long dataAfloat = fieldsA.last().split(",")[0].toLongLong(); //the "," is cause of the text input file

//            QStringList fieldsB = lineB.split(".");
//            long long dataBint = fieldsB.first().split(" ")[0].toLongLong();
//            long long dataBfloat = fieldsB.last().split(",")[0].toLongLong(); //the "," is cause of the text input file


//            diffsA.append(dataAint * multiplikator + dataAfloat);
//            diffsB.append(dataBint * multiplikator + dataBfloat);


//        }
//    }
}


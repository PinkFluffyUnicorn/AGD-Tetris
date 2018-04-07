#ifndef DATAINTERPRETER_H
#define DATAINTERPRETER_H

#include <QObject>

#include "event.h"

class DataInterpreter : public QObject
{
    Q_OBJECT
public:
    DataInterpreter();
    ~DataInterpreter();

    Q_INVOKABLE void readFilesInFolder(QString folderPath);
private:
    QList<Event*> _events;
};

#endif // DATAINTERPRETER_H

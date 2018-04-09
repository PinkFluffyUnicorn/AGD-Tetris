#ifndef DATAINTERPRETER_H
#define DATAINTERPRETER_H

#include <QQuickItem>

#include "event.h"

class DataInterpreter : public QObject
{
    Q_OBJECT
public:
    DataInterpreter(QQuickItem *comItem);
    ~DataInterpreter();

    Q_INVOKABLE void readFilesInFolder(QString folderPath);
    Q_INVOKABLE void fillOverview();
private:
    QList<Event*> _events;
    QQuickItem *_comItem;
};

#endif // DATAINTERPRETER_H

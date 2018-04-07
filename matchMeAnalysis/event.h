#ifndef EVENT_H
#define EVENT_H

#include <QString>
#include <QDateTime>

enum EEventType {
    GAME_STARTED,
    GAME_WON,

};

class Event
{
public:
    Event(int userID, QDateTime time, EEventType type, QString description);
    ~Event();

    int getUserID();
    QDateTime getTime();
    EEventType getType();
    QString getDescription();

private:
    int _userID;
    QDateTime _time;
    EEventType _type;
    QString _description; //should be used for additional information, like wich level was started or won

};

#endif // EVENT_H

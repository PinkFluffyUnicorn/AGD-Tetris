#include "event.h"

Event::Event(int userID, QDateTime time, EEventType type, QString description)
{
    _userID = userID;
    _time = time;
    _type = type;
    _description = description;
}

Event::~Event()
{

}

int Event::getUserID()
{
    return _userID;
}

QDateTime Event::getTime()
{
    return _time;
}

EEventType Event::getType()
{
    return _type;
}

QString Event::getDescription()
{
    return _description;
}


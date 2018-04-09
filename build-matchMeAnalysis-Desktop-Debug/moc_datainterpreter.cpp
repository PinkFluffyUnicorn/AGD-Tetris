/****************************************************************************
** Meta object code from reading C++ file 'datainterpreter.h'
**
** Created by: The Qt Meta Object Compiler version 67 (Qt 5.5.1)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include "../matchMeAnalysis/datainterpreter.h"
#include <QtCore/qbytearray.h>
#include <QtCore/qmetatype.h>
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'datainterpreter.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 67
#error "This file was generated using the moc from 5.5.1. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
struct qt_meta_stringdata_DataInterpreter_t {
    QByteArrayData data[5];
    char stringdata0[59];
};
#define QT_MOC_LITERAL(idx, ofs, len) \
    Q_STATIC_BYTE_ARRAY_DATA_HEADER_INITIALIZER_WITH_OFFSET(len, \
    qptrdiff(offsetof(qt_meta_stringdata_DataInterpreter_t, stringdata0) + ofs \
        - idx * sizeof(QByteArrayData)) \
    )
static const qt_meta_stringdata_DataInterpreter_t qt_meta_stringdata_DataInterpreter = {
    {
QT_MOC_LITERAL(0, 0, 15), // "DataInterpreter"
QT_MOC_LITERAL(1, 16, 17), // "readFilesInFolder"
QT_MOC_LITERAL(2, 34, 0), // ""
QT_MOC_LITERAL(3, 35, 10), // "folderPath"
QT_MOC_LITERAL(4, 46, 12) // "fillOverview"

    },
    "DataInterpreter\0readFilesInFolder\0\0"
    "folderPath\0fillOverview"
};
#undef QT_MOC_LITERAL

static const uint qt_meta_data_DataInterpreter[] = {

 // content:
       7,       // revision
       0,       // classname
       0,    0, // classinfo
       2,   14, // methods
       0,    0, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       0,       // signalCount

 // methods: name, argc, parameters, tag, flags
       1,    1,   24,    2, 0x02 /* Public */,
       4,    0,   27,    2, 0x02 /* Public */,

 // methods: parameters
    QMetaType::Void, QMetaType::QString,    3,
    QMetaType::Void,

       0        // eod
};

void DataInterpreter::qt_static_metacall(QObject *_o, QMetaObject::Call _c, int _id, void **_a)
{
    if (_c == QMetaObject::InvokeMetaMethod) {
        DataInterpreter *_t = static_cast<DataInterpreter *>(_o);
        Q_UNUSED(_t)
        switch (_id) {
        case 0: _t->readFilesInFolder((*reinterpret_cast< QString(*)>(_a[1]))); break;
        case 1: _t->fillOverview(); break;
        default: ;
        }
    }
}

const QMetaObject DataInterpreter::staticMetaObject = {
    { &QObject::staticMetaObject, qt_meta_stringdata_DataInterpreter.data,
      qt_meta_data_DataInterpreter,  qt_static_metacall, Q_NULLPTR, Q_NULLPTR}
};


const QMetaObject *DataInterpreter::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->dynamicMetaObject() : &staticMetaObject;
}

void *DataInterpreter::qt_metacast(const char *_clname)
{
    if (!_clname) return Q_NULLPTR;
    if (!strcmp(_clname, qt_meta_stringdata_DataInterpreter.stringdata0))
        return static_cast<void*>(const_cast< DataInterpreter*>(this));
    return QObject::qt_metacast(_clname);
}

int DataInterpreter::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QObject::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        if (_id < 2)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 2;
    } else if (_c == QMetaObject::RegisterMethodArgumentMetaType) {
        if (_id < 2)
            *reinterpret_cast<int*>(_a[0]) = -1;
        _id -= 2;
    }
    return _id;
}
QT_END_MOC_NAMESPACE

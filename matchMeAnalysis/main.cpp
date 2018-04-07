#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <QQmlContext>

#include "datainterpreter.h"

int main(int argc, char *argv[])
{
//    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);


    QQmlApplicationEngine engine;
    DataInterpreter* interpreter = new DataInterpreter;
    QQmlContext* context = engine.rootContext();
    context->setContextProperty("dataInterpreter", interpreter);
    engine.load(QUrl(QLatin1String("qrc:/main.qml")));

    return app.exec();
}

#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <QQmlContext>
#include <QQuickView>

#include "datainterpreter.h"

int main(int argc, char *argv[])
{
//    QCoreApplication::setAttribute(Qt::AA_EnableHighDpiScaling);
    QGuiApplication app(argc, argv);


    QQuickView view;
    view.setSource(QUrl("qrc:/main.qml"));
    view.setResizeMode(QQuickView::SizeRootObjectToView);

    QQuickItem *item = view.rootObject();
    DataInterpreter* interpreter = new DataInterpreter(item); // use qqmlquickview to avoid error

    view.rootContext()->setContextProperty("dataInterpreter", interpreter);
    view.show();


//    QQmlApplicationEngine engine;
//    QQmlContext* context = engine.rootContext();
//    context->setContextProperty("dataInterpreter", interpreter);
//    engine.load(QUrl(QLatin1String("qrc:/main.qml")));



    return app.exec();
}

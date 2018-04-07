import QtQuick 2.0
import QtQuick.Controls 1.4
import QtQuick.Layouts 1.0

ApplicationWindow {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    property var anchorMargins: 10

    TextField{
        id: inputFolder
        anchors.left: parent.left
        anchors.right: read.left
        anchors.top: parent.top
        anchors.margins: anchorMargins
        text: "/home/tobias/Documents/"
    }

    Button{
        id: read
        anchors.right: parent.right
        anchors.top: inputFolder.top
        anchors.bottom: inputFolder.bottom
        anchors.rightMargin: anchorMargins
        text: "read"
        onClicked: {
            dataInterpreter.readFilesInFolder(inputFolder.text)
        }
    }

    TabView {
        anchors.top: inputFolder.bottom
        anchors.margins: anchorMargins
        anchors.bottom: parent.bottom
        anchors.right: parent.right
        anchors.left: parent.left
        Tab {
            title: "Red"
            Rectangle { color: "red" }
        }
        Tab {
            title: "Blue"
            Rectangle { color: "blue" }
        }
        Tab {
            title: "Green"
            Rectangle { color: "green" }
        }
    }
}

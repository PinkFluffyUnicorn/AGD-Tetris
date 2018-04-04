import QtQuick 2.7
import QtQuick.Controls 1.4
import QtQuick.Layouts 1.0

ApplicationWindow {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    property var anchorMargins: 10

    TextField{
        id: inputFile
        anchors.left: parent.left
        anchors.right: transfer.left
        anchors.top: parent.top
        anchors.margins: anchorMargins
        text: "input"
    }


    TextField {
        id: outputFile
        anchors.left: parent.left
        anchors.right: transfer.left
        anchors.top: inputFile.bottom
//        anchors.bottom: parent.bottom
        anchors.margins: anchorMargins
        text: "output"
    }

    Button{
        id: transfer
        anchors.right: parent.right
        anchors.top: inputFile.top
        anchors.bottom: inputFile.bottom
        anchors.rightMargin: anchorMargins
        text: "transfer"
    }

    Button{
        id: read
        anchors.right: parent.right
        anchors.top: outputFile.top
        anchors.bottom: outputFile.bottom
        anchors.rightMargin: anchorMargins
        text: "read"
    }

    TabView {
        anchors.top: outputFile.bottom
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

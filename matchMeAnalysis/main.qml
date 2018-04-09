import QtQuick 2.0
import QtQuick.Controls 1.4
import QtQuick.Layouts 1.0

Rectangle {
    visible: true
    width: 640
    height: 480
//    title: qsTr("Hello World")

    property var anchorMargins: 10

    function fillOverview(started, lost, won){
        tabView.startedGamesText = started
        tabView.lostGamesText = lost
        tabView.wonGamesText = won
        return "some return value"
    }

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
            dataInterpreter.fillOverview()
        }
    }

    TabView {
        id:tabView
        anchors.top: inputFolder.bottom
        anchors.margins: anchorMargins
        anchors.bottom: parent.bottom
        anchors.right: parent.right
        anchors.left: parent.left

        property string startedGamesText: "0"
        property string lostGamesText: "0"
        property string wonGamesText : "0"
        Tab {
            title: "Overview"
            anchors.fill: parent
            ColumnLayout{
                RowLayout{//started games
                    Text{
                        text: "Started Games (total):"
                    }
                    Text{
                        text: tabView.startedGamesText
                    }
                }
                RowLayout{//lost games games
                    Text{
                        text: "Lost Games (total):"
                    }
                    Text{
                        text: tabView.lostGamesText
                    }
                }
                RowLayout{//won games
                    Text{
                        text: "Won Games (total):"
                    }
                    Text{
                        text: tabView.wonGamesText
                    }
                }
            }

//            Rectangle { color: "red" }
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

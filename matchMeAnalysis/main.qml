import QtQuick 2.0
import QtCharts 2.0
import QtQuick.Controls 1.4
import QtQuick.Layouts 1.0

Rectangle {
    visible: true
    width: 640
    height: 480
//    title: qsTr("Hello World")

    property var anchorMargins: 10

    property var startedGamesTotal: 0
    property var lostGamesTotal: 0
    property var wonGamesTotal : 0

    function fillOverview(started, lost, won){
        startedGamesTotal = started
        lostGamesTotal = lost
        wonGamesTotal = won
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

        Tab {
            title: "Overview"
            anchors.fill: parent
            ColumnLayout{
                RowLayout{//started games
                    Text{
                        text: "Started Games (total):"
                    }
                    Text{
                        text: startedGamesTotal
                    }
                }
                RowLayout{//lost games games
                    Text{
                        text: "Lost Games (total):"
                    }
                    Text{
                        text: lostGamesTotal
                    }
                }
                RowLayout{//won games
                    Text{
                        text: "Won Games (total):"
                    }
                    Text{
                        text: wonGamesTotal
                    }
                }
            }

//            Rectangle { color: "red" }
        }
        Tab {
            title: "Pie Chart"
            Item {
                anchors.fill: parent

                //![1]
                ChartView {
                    anchors.fill: parent
                    theme: ChartView.ChartThemeBrownSand
                    antialiasing: true

                    PieSeries {
                        id: pieSeries
                        PieSlice { label: "Lost"; value: lostGamesTotal }
                        PieSlice { label: "Won"; value: wonGamesTotal }
                    }
                }
            }
        }
        Tab {
            title: "Green"
            Rectangle { color: "green" }
        }
    }
}

//  /*********************************************************************************
//   *********************************************************************************
//   *********************************************************************************
//   * Produced by Skard Games										                 *
//   * Facebook: https://goo.gl/5YSrKw											     *
//   * Contact me: https://goo.gl/y5awt4								             *
//   * Developed by Cavit Baturalp Gürdin: https://tr.linkedin.com/in/baturalpgurdin *
//   *********************************************************************************
//   *********************************************************************************
//   *********************************************************************************/

using UnityEngine;
using System.Collections;


//Button which starts the Game
public class ContinueButton : MonoBehaviour {

    public void OnClickContinueButton()
    {
        Managers.Audio.PlayUIClick();
        //Original: 
        Managers.Game.SetState(typeof(GamePlayState));
        //LevelOverview: 
        //Managers.Game.SetState(typeof(LevelOverviewState));
    }
}

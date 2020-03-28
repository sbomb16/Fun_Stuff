using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {

        public Bike m_PlayerBike;
        public Bike m_AIBike;
        public Bike m_RedneckBike;
        public Bike m_MarioBike;

        private void Awake()
        {
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            IEngine nitroEngine = new NitroEngine();
            IDriver AIDriver = new AndroidDriver();

            m_AIBike.SetEngine(nitroEngine);
            m_AIBike.SetDriver(AIDriver);
            m_AIBike.StartEngine();

            IEngine lawnMowerEngine = new LawnMowerEngine();
            IDriver redneckDriver = new RedneckDriver();

            m_RedneckBike.SetEngine(lawnMowerEngine);
            m_RedneckBike.SetDriver(redneckDriver);
            m_RedneckBike.StartEngine();

            IEngine handCrankEngine = new HandCrankEngine();
            IDriver marioDriver = new MarioDriver();

            m_MarioBike.SetEngine(handCrankEngine);
            m_MarioBike.SetDriver(marioDriver);
            m_MarioBike.StartEngine();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("a"))
            {
                m_PlayerBike.TurnLeft();
            }
            if (Input.GetKeyDown("d"))
            {
                m_PlayerBike.TurnRight();
            }

            if (Input.GetKeyDown("f"))
            {
                m_AIBike.TurnLeft();
            }
            if (Input.GetKeyDown("h"))
            {
                m_AIBike.TurnRight();
            }

            if (Input.GetKeyDown("j"))
            {
                m_RedneckBike.TurnLeft();
            }
            if (Input.GetKeyDown("l"))
            {
                m_RedneckBike.TurnRight();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                m_MarioBike.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                m_MarioBike.TurnRight();
            }
        }

        //private void OnGUI()
        //{
        //    GUI.color = Color.black;
        //    GUI.Label(new Rect(100, 100, 500, 100), "Press A to turn Player LEFT and D to turn RIGHT");
        //    GUI.Label(new Rect(100, 120, 500, 100), "Press F to turn AI LEFT and H to turn RIGHT");
        //    GUI.Label(new Rect(1110, 130, 1000, 500), "Press J to turn Redneck LEFT and L to turn RIGHT");
        //    GUI.Label(new Rect(100, 140, 500, 100), "Press Left Arrow to turn Mario LEFT and Right Arrow to turn RIGHT");
        //    GUI.Label(new Rect(100, 150, 500, 100), "Output displayed in the debug console");
        //    GUI.Label(new Rect(100, 150, 500, 100), "Output displayed in the debug console");
        //}
    }
}
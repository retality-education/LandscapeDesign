using LandscapeDesign.Controller;
using LandscapeDesign.Enums;
using LandscapeDesign.ObserverPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign.View
{
    internal partial class FormView : Form, ILandscapeView
    {
        public LandscapeController controller;

        public FormView()
        {
            InitializeComponent();
        }

        public void MayorGoingAwayFromCity()
        {
            Console.WriteLine($"{nameof(MayorGoingAwayFromCity)}()");
        }

        public void MayorGoingToDesigner()
        {
            Console.WriteLine($"{nameof(MayorGoingToDesigner)}()");
        }

        public void MayorGeneratedIdea()
        {
            Console.WriteLine($"{nameof(MayorGeneratedIdea)}()");
        }

        public void MayorComingToCity()
        {
            Console.WriteLine($"{nameof(MayorComingToCity)}()");
        }

        public void DesignerRidingToCity()
        {
            Console.WriteLine($"{nameof(DesignerRidingToCity)}()");
        }

        public void DesignerComeToArea(int areaId)
        {
            Console.WriteLine($"{nameof(DesignerComeToArea)}(areaId: {areaId})");
        }

        public void DesignerComeBackToShop()
        {
            Console.WriteLine($"{nameof(DesignerComeBackToShop)}()");
        }

        public void FlowerChangeStateToWilted(int areaId, int flowerId, FlowerType flowerType)
        {
            Console.WriteLine($"{nameof(FlowerChangeStateToWilted)}(areaId: {areaId}, flowerId: {flowerId}, flowerType: {flowerType})");
        }

        public void FlowerChanged(int areaId, int flowerId, FlowerType flowerType)
        {
            Console.WriteLine($"{nameof(FlowerChanged)}(areaId: {areaId}, flowerId: {flowerId}, flowerType: {flowerType})");
        }

        public void MainObjectEndBuilding(int areaId, ObjectType objectType)
        {
            Console.WriteLine($"{nameof(MainObjectEndBuilding)}(areaId: {areaId}, objectType: {objectType})");
        }

        public void MainObjectStartBuilding(int areaId)
        {
            Console.WriteLine($"{nameof(MainObjectStartBuilding)}(areaId: {areaId})");
        }

        public void CreatePlaceForFlower(int areaId, int flowerId)
        {
            Console.WriteLine($"{nameof(CreatePlaceForFlower)}(areaId: {areaId}, flowerId: {flowerId})");
        }

        public void CreatePlaceForObject(int areaId)
        {
            Console.WriteLine($"{nameof(CreatePlaceForObject)}(areaId: {areaId})");
        }

        public void OnCityEvent(CityEventArgs e)
        {
            switch (e.EventType)
            {
                case EventType.MayorGoingAwayFromCity:
                    MayorGoingAwayFromCity();
                    break;

                case EventType.MayorGoingToDesigner:
                    MayorGoingToDesigner();
                    break;

                case EventType.MayorGeneratedIdea:
                    MayorGeneratedIdea();
                    break;

                case EventType.MayorComingToCity:
                    MayorComingToCity();
                    break;

                case EventType.DesignerRidingToCity:
                    DesignerRidingToCity();
                    break;

                case EventType.DesignerComeToArea:
                    DesignerComeToArea(e.AreaId);
                    break;

                case EventType.DesignerComeBackToShop:
                    DesignerComeBackToShop();
                    break;

                case EventType.FlowerChangeStateToWilted:
                    FlowerChangeStateToWilted(e.AreaId, e.FlowerId, e.FlowerType);
                    break;

                case EventType.FlowerChanged:
                    FlowerChanged(e.AreaId, e.FlowerId, e.FlowerType);
                    break;

                case EventType.MainObjectEndBuilding:
                    MainObjectEndBuilding(e.AreaId, e.ObjectType);
                    break;

                case EventType.MainObjectStartBuilding:
                    MainObjectStartBuilding(e.AreaId);
                    break;

                case EventType.CreatePlaceForFlower:
                    CreatePlaceForFlower(e.AreaId, e.FlowerId);
                    break;

                case EventType.CreatePlaceForObject:
                    CreatePlaceForObject(e.AreaId);
                    break;

                default:
                    Console.WriteLine($"Unknown event type: {e.EventType}");
                    break;
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            controller.Start();
        }
    }
}

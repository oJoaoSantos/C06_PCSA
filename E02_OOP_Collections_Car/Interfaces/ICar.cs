using E02_OOP_Collections_Car.Classes;
using System;
using System.Collections.Generic;
using static E02_OOP_Collections_Car.Classes.Car;

namespace E02_OOP_Collections_Car.Interfaces
{
    internal interface ICar
    {
        #region Properties
        EnumBrand? Brand { get; }
        EnumModel? Model { get;  }
        EnumColor? Color { get; }
        string LicensePlate { get; }
        int Displacement { get; }
        int Velocity { get; }
        DateTime RegistrationDate { get; }
        #endregion

        #region Methods

        #region Ask and validate Car Properties
        int AskBrand();

        int AskModel();

        int AskColor();
        string AskLicensePlate();
        int AskDisplacement();
        DateTime AskRegistrationDate();
        #endregion

        #region Create New car
        void CreateNewCar(List<Car> car, EnumBrand? brand, EnumModel? model, EnumColor? color, string plate, int disp, DateTime regist);
        #endregion

        #region Stop
        void Stop(Car car, List<Car> list);
        #endregion

        #region Acelerate
        void Acelerate(Car car, List<Car> list);
        #endregion

        #region Decelerate
        void Decelerate(Car car, List<Car> list);
        #endregion

        #region Drive
        void Drive(Car car, List<Car> list);
        #endregion

        #region Show Lists
        void ShowList(List<Car> list);
        void ShowVelocity(List<Car> list);
        #endregion


        #endregion
    }
}

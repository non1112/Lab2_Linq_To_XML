using Lab2_Linq_To_XML.Enums;
using Lab2_Linq_To_XML.Interface;
using System;
using System.Collections.Generic;

namespace Lab2_Linq_To_XML
{
    class CommandInvoker: ICommandInvoker
    {
        private IDataOutput _dataOutput;
        public CommandInvoker(IDataOutput dataOutput)
        {
            _dataOutput = dataOutput;
        }
        public Dictionary<Command,Action> RunCommand()
        {
            var dictionarycommand = new Dictionary<Command, Action>()
            {
                {Command.CreateXmlFile,  _dataOutput.CreateXmlFile },
                {Command.GetAllCar, _dataOutput.GetAllCar },
                {Command.Exit, _dataOutput.Exit },
                {Command.GetManufacturersNotFromCountry,_dataOutput.GetManufacturersNotFromCountry},
                {Command.GetBrandsSort,_dataOutput.GetBrandsSort },
                {Command.GetLatestCar,_dataOutput.GetLatestCar },
                {Command.GroupCarTechnicalCondition,_dataOutput.GroupCarTechnicalCondition},
                {Command.GetDriverSort,_dataOutput.GetDriverSort},
                {Command.ValueCarManufacture,_dataOutput.ValueCarManufacture},
                {Command.CarWithBodyType,_dataOutput.CarWithBodyType },
                {Command.UseElementAt,_dataOutput.UseElementAt },
                {Command.UseSkip,_dataOutput.UseSkip },
                {Command.JoinDriverCar,_dataOutput.JoinDriverCar },
                {Command.GetOldestOwner,_dataOutput.GetOldestOwner},
                {Command.GetCarsAfterYears,_dataOutput.GetCarsAfterYears },
                {Command.SortRegistrationForRegDate,_dataOutput.SortRegistrationForRegDate},
                {Command.GetLicenseNumber,_dataOutput.GetLicenseNumber},
                {Command.ShowAll,_dataOutput.ShowAll }
            };
            return dictionarycommand;
        }
    }
}

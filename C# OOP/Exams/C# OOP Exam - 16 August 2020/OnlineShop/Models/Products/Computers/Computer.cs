using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;


        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public override double OverallPerformance
        {
            get
            {
                if (components.Count==0)
                {
                    return base.OverallPerformance;
                }
                else
                {
                    return base.OverallPerformance + components.Average(c => c.OverallPerformance);
                }
            }
        }

        public override decimal Price => base.Price+components.Sum(c=>c.Price)+peripherals.Sum(p=>p.Price);

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();
        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();

        public void AddComponent(IComponent component)
        {
            var existingComponent = components.FirstOrDefault(c => c.GetType().Name == component.GetType().Name);

            if (existingComponent!=null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name,
                    GetType().Name, Id));
            }
            components.Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            var existingComponent = components.FirstOrDefault(c => c.GetType().Name == componentType);
            if (components.Count==0 || existingComponent==null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingComponent, componentType,
                    GetType().Name, Id));
            }

            components.Remove(existingComponent);
            return existingComponent;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            var existingPeripheral = peripherals.FirstOrDefault(c => c.GetType().Name == peripheral.GetType().Name);

            if (existingPeripheral != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name,
                    GetType().Name, Id));
            }
            peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            var existingPeripheral = peripherals.FirstOrDefault(c => c.GetType().Name == peripheralType);

            if (peripherals.Count == 0 || peripheralType == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingPeripheral, peripheralType,
                    GetType().Name, Id));
            }

            peripherals.Remove(existingPeripheral);
            return existingPeripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" Components ({components.Count}):");
            if (components.Count>0)
            {
                foreach (var component in components)
                {
                    sb.AppendLine($"  {component.ToString()}");
                }
            }

           double performans = peripherals.Count > 0 ? (peripherals.Average(p => p.OverallPerformance)) : 0;
            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({performans:f2}):");
            if (peripherals.Count>0)
            {
                foreach (var peripheral in peripherals)
                {
                    sb.AppendLine($"  {peripheral.ToString()}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}

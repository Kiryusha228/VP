using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLib
{
    public class Shop
    {
        private List<Item> _items;

        public Shop()
        {
            _items = new List<Item>();
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }
        public void Remove(Item item)
        {
            _items.Remove(item);
        }

        public string SortByVendor()
        {
            var sortedItems = from item in _items
                              orderby item.Vendor, item.Name
                              select item;

            StringBuilder sb = new StringBuilder();
            foreach (var item in sortedItems)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string SortByVendorFluent()
        {
            var sortedItemsFluent = _items.OrderBy(item => item.Vendor).ThenBy(item => item.Name);

            StringBuilder sb = new StringBuilder();
            foreach (var item in sortedItemsFluent)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string SearchByVendor(string vendor)
        {
            var query = from item in _items
                        where item.Vendor == vendor
                        select item;

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string SearchByVendorFluent(string vendor)
        {
            var fluentQuery = _items.Where(item => item.Vendor == vendor);

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string Get3ExpensiveItems()
        {
            var query = (from item in _items
                        orderby item.Price descending
                        select item).Take(3);
            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string Get3ExpensiveItemsFluent()
        {
            var fluentQuery = _items.OrderByDescending(item => item.Price).Take(3);

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GetItemsNowYear()
        {
            var query = from item in _items
                        where item.DateOfManufacture.Year == DateTime.Now.Year
                        select item;

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GetItemsNowYearFluent()
        {
            var fluentQuery = _items.Where(item => item.DateOfManufacture.Year == DateTime.Now.Year);

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GetLastManufacturedItem()
        {
            var query = (from item in _items
                        orderby item.DateOfManufacture descending
                        select item).FirstOrDefault()!;

            return query.ToString();
        }

        public string GetLastManufacturedItemFluent()
        {
            var fluentQuery = _items.OrderByDescending(item => item.DateOfManufacture).FirstOrDefault()!;

            return fluentQuery.ToString();
        }

        public string GetCountVendorsWithItemName(string name)
        {
            var query = (from item in _items
                        where item.Name == name
                        select item.Vendor).Distinct().Count();

            return query.ToString();
        }

        public string GetCountVendorsWithItemNameFluent(string name)
        {
            var fluentQuery = _items
                .Where(item => item.Name == name)
                .Select(item => item.Vendor).Distinct().Count();

            return fluentQuery.ToString();
        }

        public string GetVendorsWithPrice()
        {
            var query = from item in _items
                        group item by item.Vendor into vendorGroup
                        where vendorGroup.All(item => item.Price > 10000)
                        select vendorGroup.Key;

            StringBuilder sb = new StringBuilder();
            foreach (var vendor in query)
            {
                sb.AppendLine(vendor);
            }
            return sb.ToString();
        }

        public string GetVendorsWithPriceFluent()
        {
            var fluentQuery = _items.GroupBy(item => item.Vendor)
                       .Where(vendorGroup => vendorGroup.All(item => item.Price > 10000))
                       .Select(vendorGroup => vendorGroup.Key);

            StringBuilder sb = new StringBuilder();
            foreach (var vendor in fluentQuery)
            {
                sb.AppendLine(vendor);
            }
            return sb.ToString();
        }

        public string GetItemsFromTaskH()
        {
            var query = (from item in _items
                         where item.DateOfManufacture.Year != DateTime.Now.Year
                         select item).Union(from item in _items
                                            where item.Price < _items.Average(item => item.Price)
                                            select item);
                

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GetItemsFromTaskHFluent()
        {
            var fluentQuery = _items.Where(item => item.DateOfManufacture.Year != DateTime.Now.Year)
                .Union(_items.Where(item => item.Price < _items.Average(item => item.Price)));
               

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string ShowItems()
        {
            var query = from item in _items
                        select $"{item.Article} {item.Name} {item.Color}";

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string ShowItemsFluent()
        {
            var fluentQuery = _items.Select(item => $"{item.Article} {item.Name} {item.Color}");

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GetMinPriceForVendor()
        {
            var query = from item in _items
                        group item by item.Vendor into vendorGroup
                        select new { Vendor = vendorGroup.Key, MinPrice = vendorGroup.Min(item => item.Price) };

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendLine($"{item.Vendor}, {item.MinPrice}");
            }
            return sb.ToString();
        }

        public string GetMinPriceForVendorFluent()
        {
            var fluentQuery = _items.GroupBy(item => item.Vendor)
                          .Select(vendorGroup => new { Vendor = vendorGroup.Key, MinPrice = vendorGroup.Min(item => item.Price) });

            StringBuilder sb = new StringBuilder();
            foreach (var item in fluentQuery)
            {
                sb.AppendLine($"{item.Vendor}, {item.MinPrice}");
            }
            return sb.ToString();
        }
    }
}

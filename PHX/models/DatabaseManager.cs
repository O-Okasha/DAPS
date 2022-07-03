using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace PHX.models
{
    public class DatabaseManager
    {
        public DatabaseManager() { }

        private const string ConnectionString = "mongodb://localhost:27017";
        private const string database = "pharmacy";
        private const string CustomerCollection = "Customers";
        private const string MedicineCollection = "Medicine";
        private const string SupplierCollection = "Supplier";
        private const string StoreCollection = "Store";
        private const string ShelfsCollection = "Shelf";
        private const string CategoryCollection = "Category";
        private const string PurchaseCollection = "Purchase";
        private const string StockListCollection = "Stock List";
        private const string SalesCollection = "Sales";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(database);
            return db.GetCollection<T>(collection);
        }

        public Task AddMedicine(Medicine med)
        {
            var MedCollection = ConnectToMongo<Medicine>(MedicineCollection);
            return MedCollection.InsertOneAsync(med);
        }

        public async Task<List<Medicine>> TotalMedicines()
        {
            var MedCollection = ConnectToMongo<Medicine>(MedicineCollection);
            var results = await MedCollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task Upsertmedicine(Medicine med)
        {
            var medicinecollection = ConnectToMongo<Medicine>(MedicineCollection);
            var filter = Builders<Medicine>.Filter.Eq("BatchNumber", med.MedBatchNumber);
            return medicinecollection.ReplaceOneAsync(filter, med, new ReplaceOptions { IsUpsert = true });
        }
        public async Task<List<Shelf>> TotalShelfs()
        {
            var shelfcollection = ConnectToMongo<Shelf>(ShelfsCollection);
            var results = await shelfcollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddShelf(Shelf shelf)
        {
            var shelfCollection = ConnectToMongo<Shelf>(ShelfsCollection);
            return shelfCollection.InsertOneAsync(shelf);
        }
        public Task AddCategory(Category category)
        {
            var categorycollection = ConnectToMongo<Category>(CategoryCollection);
            return categorycollection.InsertOneAsync(category);
        }
        public Task AddCustomer(Customer customer)
        {
            var customercollection = ConnectToMongo<Customer>(CustomerCollection);
            return customercollection.InsertOneAsync(customer);
        }
        public Task Upsertcustomer(Customer customer)
        {
            var customercollection = ConnectToMongo<Customer>(CustomerCollection);
            var filter = Builders<Customer>.Filter.Eq("Name", customer.Name);
            return customercollection.ReplaceOneAsync(filter, customer, new ReplaceOptions { IsUpsert = true });
        }
        public Task AddSupplier(Supplier supplier)
        {
            var suppliercollection = ConnectToMongo<Supplier>(SupplierCollection);
            return suppliercollection.InsertOneAsync(supplier);
        }
        public Task UpsertSupplier(Supplier supplier)
        {
            var suppliercollection = ConnectToMongo<Supplier>(SupplierCollection);
            var filter = Builders<Supplier>.Filter.Eq("Name", supplier.Name);
            return suppliercollection.ReplaceOneAsync(filter, supplier, new ReplaceOptions { IsUpsert = true });
        }
        public async Task<List<Supplier>> TotalSuppliers()
        {
            var suppliercollection = ConnectToMongo<Supplier>(SupplierCollection);
            var results = await suppliercollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddPurchase(Purchase purchase)
        {
            var purchasecollection = ConnectToMongo<Purchase>(PurchaseCollection);
            return purchasecollection.InsertOneAsync(purchase);
        }
        public Task UpsertPurchase(Purchase purchase)
        {
            var purchasecollection = ConnectToMongo<Purchase>(PurchaseCollection);
            var filter = Builders<Purchase>.Filter.Eq("ID", purchase.ID);
            return purchasecollection.ReplaceOneAsync(filter, purchase, new ReplaceOptions { IsUpsert = true });
        }
        public async Task<List<Purchase>> TotalPurchase()
        {
            var purchasecollection = ConnectToMongo<Purchase>(PurchaseCollection);
            var results = await purchasecollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddStockList(StockList stockList)
        {
            var StockListcollection = ConnectToMongo<StockList>(StockListCollection);
            return StockListcollection.InsertOneAsync(stockList);
        }
        public Task UpsertStockList(StockList stockList)
        {
            var StockListcollection = ConnectToMongo<StockList>(StockListCollection);
            var filter = Builders<StockList>.Filter.Eq("TotalQuantity", stockList.TotalQuantity);
            return StockListcollection.ReplaceOneAsync(filter, stockList, new ReplaceOptions { IsUpsert = true });
        }
        public async Task<List<StockList>> TotalStockList()
        {
            var StockListcollection = ConnectToMongo<StockList>(StockListCollection);
            var results = await StockListcollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddSales(Sale sale)
        {
            var Salescollection = ConnectToMongo<Sale>(SalesCollection);
            return Salescollection.InsertOneAsync(sale);
        }
        public Task UpsertSales(Sale sale)
        {
            var Salecollection = ConnectToMongo<Sale>(SalesCollection);
            var filter = Builders<Sale>.Filter.Eq("Discount", sale.Discount);
            return Salecollection.ReplaceOneAsync(filter, sale, new ReplaceOptions { IsUpsert = true });
        }
        public async Task<List<Sale>> TotalSales()
        {
            var Salecollection = ConnectToMongo<Sale>(SalesCollection);
            var results = await Salecollection.FindAsync(_ => true);
            return results.ToList();
        }
        public Task AddStoreSettings(Store_Settings store_settings)
        {
            var storesettingcollection = ConnectToMongo<Store_Settings>(StoreCollection);
            return storesettingcollection.InsertOneAsync(store_settings);
        }
        public Task UpsertStoreList(Store_Settings store_Settings)
        {
            var Sscollection = ConnectToMongo<Store_Settings>(StoreCollection);
            var filter = Builders<Store_Settings>.Filter.Eq("store name", store_Settings.Name);
            return Sscollection.ReplaceOneAsync(filter, store_Settings, new ReplaceOptions { IsUpsert = true });
        }

        /*public Task CreateShelf(Shelf shelf) 
        {
            var shelfcollection = ConnectToMongo<Shelf>(ShelfsCollection);
            return shelfcollection.InsertOneAsync(shelf);
        }
        public Task Createcategory(Category category)
        {
            var categorycollection = ConnectToMongo<Category>(CategoryCollection);
            return categorycollection.InsertOneAsync(category);
        }
        public Task CreateMedicine(Medicine medicine)
        {
            var medcollection = ConnectToMongo<Medicine>(MedicineCollection);
            return medcollection.InsertOneAsync(medicine);
        }
        public Task CreateCustomer(Customer customer)
        {
            var cuscollection = ConnectToMongo<Customer>(CustomerCollection);
            return cuscollection.InsertOneAsync(customer);
        }
        public Task CreateSupplier(Supplier supplier)
        {
            var supcollection = ConnectToMongo<Supplier>(SupplierCollection);
            return supcollection.InsertOneAsync(supplier);

        }
        public Task CreatePurchase(Purchase purchase)
        {
            var purcollection = ConnectToMongo<Purchase>(PurchaseCollection);
            return purcollection.InsertOneAsync(purchase);
        }
        public Task CreateStockList(StockList stockList)
        {
            var slcollection = ConnectToMongo<StockList>(StockListCollection);
            return slcollection.InsertOneAsync(stockList);
        }
        public Task CreateSales(Sale sale)
        {
            var salecollection = ConnectToMongo<Sale>(SalesCollection);
            return salecollection.InsertOneAsync(sale);
        }
        public Task CreateStoresettings(Store_Settings store_Settings)
        {
            var ssecollection = ConnectToMongo<Store_Settings>(StoreCollection);
            return ssecollection.InsertOneAsync(store_Settings);
        }*/

    }


}

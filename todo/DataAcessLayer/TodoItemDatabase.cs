using System;
using System.IO;
using System.Threading.Tasks;
using SQLite;

namespace DataAcessLayer
{
    public class TodoItemDatabase
    {
        static SQLiteAsyncConnection database;

        public TodoItemDatabase()
        {
            database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
            database.CreateTableAsync<TodoItem>().Wait();
        }

        public async Task<TodoItem> GetItemsAsync()
        {
            return await database.Table<TodoItem>().FirstOrDefaultAsync();
        }


        public  async Task<TodoItem> GetItemAsync(int id)
        {
            return await database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public  async Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return await database.UpdateAsync(item);
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }


    }
}

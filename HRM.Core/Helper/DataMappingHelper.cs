using AutoMapper;
using Core.Entity;
using System.Data;
using System.Data.Common;

namespace Core.Helper
{
    public class DataMappingHelper<TEntity>
    {

        public static TEntity? DataMapper(DbDataReader dataReader,IMapper _mapper)
        {
            if(dataReader == null)
            {
                throw new ArgumentNullException("Not Found");
            }
            dynamic entityMapper = null;
            string entityName = typeof(TEntity).Name; 
           
     
            //if(entityName == typeof(User).Name)
            //{

            //    User user = new User();
            //    user.AccountId = dataReader.GetGuid(0);
            //    user.Name = dataReader.GetString(1);
            //    user.Phone = dataReader.IsDBNull("Phone") ? null : dataReader.GetString(2);
            //    user.Address = dataReader.IsDBNull("Address") ? null : dataReader.GetString(3);
            //    user.Age = dataReader.IsDBNull("Age") ? null : dataReader.GetInt32(4);
            //    user.Avatar = dataReader.IsDBNull("Avatar") ? null : dataReader.GetString(5); 
            //    entityMapper = _mapper.Map<TEntity>(user); 

            //}
            //else 
            
            if(entityName == typeof(Account).Name)
            {
               
                Account account = new Account(); 
                account.AccountId = dataReader.GetGuid(0);
                account.Email = dataReader.GetString(1);
                account.Password = dataReader.GetString(2);
                account.Role = dataReader.GetString(3);
                account.Status = dataReader.GetInt32(4);
                entityMapper = _mapper.Map<TEntity>(account)!;
            }

            return entityMapper; 
        } 
    }
}

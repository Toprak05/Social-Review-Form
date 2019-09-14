using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDKWebPortalWebAPI.Models;

namespace SDKWebPortalWebAPI.Repository
{
    //This is the implementation of the methods. Different methods can be implemented by providing an implementation of the PostRepository.
    public class PostRepository : IPostRepository 
    {
        SDKWebPortalWebAPIContex db; //Database connection via controller
        public PostRepository(SDKWebPortalWebAPIContex _db) //This inherits the database.
        {
            db = _db;
        }
        public async Task<int> AddPost(Input input) //This method adds posts into database.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                int house = 0; //The variable that specifies where the new post placed.
                if (input.House != null) //Compares the data in the database and if is not equal adds new data.
                {
                    db.Add(input.House); //Adds new data.
                    db.SaveChanges(); //Saves changes.

                    house = input.House.Id; //Assigns new houseId.
                }

                if (input.FamilyMembers != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.FamilyMembers) //Searchs in FamilyMembers table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (input.HouseAnswers != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.HouseAnswers) //Searchs in HouseAnswers table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (input.HouseQuestions != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.HouseQuestions) //Searchs in HouseQuestions table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (input.ObservationAnswers != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.ObservationAnswers) //Searchs in ObservationAnswers table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (input.ObservationQuestions != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.ObservationQuestions) //Searchs in ObservationQuestions table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges();  //Saves changes.
                }

                if (input.PersonelAnswers != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.PersonelAnswers) //Searchs in PersonelAnswers table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges();  //Saves changes.
                }

                if (input.PersonelQuestions != null) //Compares the data in the database and if is not equal adds new data.
                {
                    foreach (var item in input.PersonelQuestions) //Searchs in PersonelQuestions table if the data does not exist, adds data.
                    {
                        item.HouseId = house; //Assings the houseId.
                        db.Add(item); //Adds into database.
                    }
                    db.SaveChanges();  //Saves changes.
                }

                return 0;
            }
            catch (Exception ex) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                throw;
            }
        }

        public async Task<int> DeletePost(int houseid) //This method deletes the data in the database.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var house = db.House.Where(x => x.Id == houseid).FirstOrDefault(); //Compares by houseid and finds it.
                    db.Remove(house); //Removes the record.
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var familyMembers = db.FamilyMembers.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in familyMembers) //Searchs item in the FamilyMembers table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var houseAnswers =db.HouseAnswers.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in houseAnswers) //Searchs item in the HouseAnswers table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var houseQuestions = db.HouseQuestions.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in houseQuestions) //Searchs item in the HouseQuestions table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var observationAnswers = db.ObservationAnswers.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in observationAnswers) //Searchs item in the ObservationAnswers table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var observationQuestions = db.ObservationQuestions.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in observationQuestions) //Searchs item in the ObservationQuestions table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var personelAnswers = db.PersonelAnswers.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in personelAnswers) //Searchs item in the PersonelAnswers table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                if (houseid != 0) //Compares the houseid. If is not equal to zero, it means that record was found and deletes it.
                {
                    var personelQuestions = db.PersonelQuestions.Where(x => x.HouseId == houseid).ToList(); //Compares by houseid and lists it.
                    foreach (var item in personelQuestions) //Searchs item in the PersonelQuestions table.
                    {
                        db.Remove(item); //Removes the record.
                    }
                    db.SaveChanges(); //Saves changes.
                }

                return 0;
            }
            catch (Exception ex) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                throw;
            }
            
        }
        
        public OutputList GetPost(int? postId) //Adds posts by taking postId.
        {
            var house = db.House.Where(x => x.Id == postId).FirstOrDefault(); //Compares by postId and gets its firts index or default index.
            var family = db.FamilyMembers.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var houseAnswers = db.HouseAnswers.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var houseQuestions = db.HouseQuestions.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var observationAnswers = db.ObservationAnswers.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var observationQuestions = db.ObservationQuestions.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var personelAnswers = db.PersonelAnswers.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.
            var personelQuestions = db.PersonelQuestions.Where(x => x.HouseId == postId).ToList(); //Compares by postId and lists it.

            OutputList outp = new OutputList //Updates the tables.
            {
                FamilyMembers = family,
                House = house,
                HouseAnswers = houseAnswers,
                HouseQuestions = houseQuestions,
                ObservationAnswers = observationAnswers,
                ObservationQuestions = observationQuestions,
                PersonelAnswers = personelAnswers,
                PersonelQuestions = personelQuestions
            };

            return outp; //returns the new tables.
        }

        public List<OutputList> GetPosts() //Retrieves data as a list.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                var house = db.House.ToList(); //Lists the House table.
                List<OutputList> response = (from h in db.House //All records come from the House table.
                                             select new OutputList //Selects the all members.
                                             {
                                                 House = h,
                                                 FamilyMembers = db.FamilyMembers.Where(c => c.HouseId == h.Id).ToList(),
                                                 HouseQuestions = db.HouseQuestions.Where(c => c.HouseId == h.Id).ToList(),
                                                 HouseAnswers = db.HouseAnswers.Where(c => c.HouseId == h.Id).ToList(),
                                                 ObservationQuestions = db.ObservationQuestions.Where(c => c.HouseId == h.Id).ToList(),
                                                 ObservationAnswers = db.ObservationAnswers.Where(c => c.HouseId == h.Id).ToList(),
                                                 PersonelQuestions = db.PersonelQuestions.Where(c => c.HouseId == h.Id).ToList(),
                                                 PersonelAnswers = db.PersonelAnswers.Where(c => c.HouseId == h.Id).ToList()
                                             }).ToList(); //Lists them.

                return response; //Returns the list.

            }
            catch (Exception ex) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                throw ex;
            };
        }
    }
}
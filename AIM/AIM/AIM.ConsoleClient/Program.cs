using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using TrackableEntities.Client;
using AIM.Client.Entities.Models;

// This is an example which retrieves customers and orders from the Northwind
// sample database. You should alter the code based on your own database schema.

namespace AIM.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main method
            
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();

            IUserService userService = new ChannelFactory<IUserService>("userService").CreateChannel();
            IQuestionService questionService = new ChannelFactory<IQuestionService>("questionService").CreateChannel();
            IJobService jobService = new ChannelFactory<IJobService>("jobService").CreateChannel();

            using ((IDisposable)userService)
            using ((IDisposable)questionService)
            using ((IDisposable)jobService)
            {
                try
                {
                    //////  Users  //////
                    
                    // Get users
                    Console.WriteLine("Users:");
                    IEnumerable<User> users = userService.GetUsersListAsync().Result;
                    if (users == null) return;
                    foreach (var u in users)
                        PrintUser(u);

                    // Get user
                    Console.WriteLine("\nGet user details {userId}:");
                    int userId = int.Parse(Console.ReadLine());
                    if (!users.Any(u => u.userId == userId))
                    {
                        Console.WriteLine("Invalid user id: {0}", userId);
                        return;
                    }
                    User user = userService.GetUserAsync(userId).Result;
                        PrintUser(user);

                    // Create a new job
                    Console.WriteLine(
                        "\nPress Enter to create a new user for {0}",
                        userId);
                    Console.ReadLine();

                    var newUser = new User
                    {
                        userId = userId,
                        firstName = "John",
                        middleName = "A.",
                        lastName = "Smith",
                        email = "john.smith@email.com",
                        socialSecurityNumber = "111-11-1111",
                        PersonalInfoId = 1,
                        employeeId = 1,
                        applicantId = 1,
                        applicationId = 1
                    };
                    var createdUser = userService.CreateUserAsync(newUser).Result;
                    PrintUser(createdUser);

                    // Update the user
                    Console.WriteLine("\nPress Enter to update user details");
                    Console.ReadLine();

                    // Start change-tracking the order
                    var changeTracker = new ChangeTrackingCollection<User>(createdUser);

                    // Submit changes
                    User changedUser = changeTracker.GetChanges().SingleOrDefault();
                    User updatedUser = userService.UpdateUserAsync(changedUser).Result;

                    // Merge changes
                    changeTracker.MergeChanges(ref createdUser, updatedUser);
                    Console.WriteLine("Updated user:");
                    PrintUser(createdUser);

                    // Delete the user
                    Console.WriteLine("\nPress Enter to delete the user");
                    Console.ReadLine();
                    bool deleted = userService.DeleteUserAsync(createdUser.userId).Result;

                    // Verify user was deleted
                    User deletedUser = userService.GetUserAsync(createdUser.userId).Result;
                    Console.WriteLine(deleted && deletedUser == null
                        ? "User was successfully deleted"
                        : "User was not deleted");

                    //////  Jobs  //////

                    // Get jobs
                    Console.WriteLine("Jobs:");
                    IEnumerable<Job> jobs = jobService.GetJobsListAsync().Result;
                    if (jobs == null) return;
                    foreach (var j in jobs)
                        PrintJob(j);

                    // Get job
                    Console.WriteLine("\nGet job details {userId}:");
                    int jobId = int.Parse(Console.ReadLine());
                    if (!jobs.Any(j => j.jobId == jobId))
                    {
                        Console.WriteLine("Invalid job id: {0}", userId);
                        return;
                    }
                    Job job = jobService.GetJobAsync(jobId).Result;
                    PrintJob(job);

                    // Create a new job
                    Console.WriteLine(
                        "\nPress Enter to create a new job for {0}",
                        jobId);
                    Console.ReadLine();

                    var newJob = new Job
                    {
                        jobId = userId,
                        position = "position",
                        description = "description",
                        fullPartTime = "FullTime",
                        salaryRange = "$40,000",
                        hoursId = 1,
                        questionnaireId = 1
                    };
                    var createdJob = jobService.CreateJobAsync(newJob).Result;
                    PrintJob(createdJob);

                    // Update the job
                    Console.WriteLine("\nPress Enter to update job details");
                    Console.ReadLine();

                    // Start change-tracking the order
                    var changeTrackerJob = new ChangeTrackingCollection<Job>(createdJob);

                    // Submit changes
                    Job changedJob = changeTrackerJob.GetChanges().SingleOrDefault();
                    Job updatedJob = jobService.UpdateJobAsync(changedJob).Result;

                    // Merge changes
                    changeTrackerJob.MergeChanges(ref createdJob, updatedJob);
                    Console.WriteLine("Updated job:");
                    PrintJob(createdJob);

                    // Delete the job
                    Console.WriteLine("\nPress Enter to delete the job");
                    Console.ReadLine();
                    bool deletedJ = jobService.DeleteJobAsync(createdJob.jobId).Result;

                    // Verify job was deleted
                    Job deletedJob = jobService.GetJobAsync(createdJob.jobId).Result;
                    Console.WriteLine(deletedJ && deletedJob == null
                        ? "Job was successfully deleted"
                        : "Job was not deleted");

                    // Get questions
                    Console.WriteLine("Questions:");
                    IEnumerable<Question> questions = questionService.GetQuestionsListAsync().Result;
                    if (questions == null) return;
                    foreach (var q in questions)
                        PrintQuestion(q);

                    // Get question
                    Console.WriteLine("\nGet quesiton details {userId}:");
                    int questionId = int.Parse(Console.ReadLine());
                    if (!questions.Any(q => q.questionId == questionId))
                    {
                        Console.WriteLine("Invalid question id: {0}", questionId);
                        return;
                    }
                    Question question = questionService.GetQuestionAsync(questionId).Result;
                    PrintQuestion(question);

                    //// Get orders for a customer
                    ////Console.WriteLine("\nGet user details {userId}:");
                    ////int userId = int.Parse(Console.ReadLine());
                    ////if (!users.Any(u => u.userId == userId))
                    ////{
                    ////    Console.WriteLine("Invalid user id: {0}", userId);
                    ////    return;
                    ////}
                    ////IEnumerable<PersonalInfo> personalInfos = orderService.GetCustomerOrdersAsync(customerId).Result;
                    ////foreach (var o in orders)
                    ////    PrintOrder(o);

                    //// Get an job
                    //Console.WriteLine("\nGet an job {OrderId}:");
                    //int orderId = int.Parse(Console.ReadLine());
                    //if (!orders.Any(o => o.OrderId == orderId))
                    //{
                    //    Console.WriteLine("Invalid order id: {0}", orderId);
                    //    return;
                    //}
                    //Order order = orderService.GetOrderAsync(orderId).Result;
                    //PrintOrderWithDetails(order);

                    //// Create a new order
                    //Console.WriteLine("\nPress Enter to create a new order for {0}",
                    //    customerId.ToUpper());
                    //Console.ReadLine();

                    //var newOrder = new Order
                    //{
                    //    CustomerId = customerId,
                    //    OrderDate = DateTime.Today,
                    //    ShippedDate = DateTime.Today.AddDays(1),
                    //    OrderDetails = new ChangeTrackingCollection<OrderDetail>
                    //        {
                    //            new OrderDetail { ProductId = 1, Quantity = 5, UnitPrice = 10 },
                    //            new OrderDetail { ProductId = 2, Quantity = 10, UnitPrice = 20 },
                    //            new OrderDetail { ProductId = 4, Quantity = 40, UnitPrice = 40 }
                    //        }
                    //};
                    //var createdOrder = orderService.CreateOrderAsync(newOrder).Result;
                    //PrintOrderWithDetails(createdOrder);

                    //// Update the order
                    //Console.WriteLine("\nPress Enter to update order details");
                    //Console.ReadLine();

                    //// Start change-tracking the order
                    //var changeTracker = new ChangeTrackingCollection<Order>(createdOrder);

                    //// Modify order details
                    //createdOrder.OrderDetails[0].UnitPrice++;
                    //createdOrder.OrderDetails.RemoveAt(1);
                    //createdOrder.OrderDetails.Add(new OrderDetail
                    //{
                    //    OrderId = createdOrder.OrderId,
                    //    ProductId = 3,
                    //    Quantity = 15,
                    //    UnitPrice = 30
                    //});

                    //// Submit changes
                    //Order changedOrder = changeTracker.GetChanges().SingleOrDefault();
                    //Order updatedOrder = orderService.UpdateOrderAsync(changedOrder).Result;

                    //// Merge changes
                    //changeTracker.MergeChanges(ref createdOrder, updatedOrder);
                    //Console.WriteLine("Updated order:");
                    //PrintOrderWithDetails(createdOrder);

                    //// Delete the order
                    //Console.WriteLine("\nPress Enter to delete the order");
                    //Console.ReadLine();
                    //bool deleted = orderService.DeleteOrderAsync(createdOrder.OrderId).Result;

                    //// Verify order was deleted
                    //Order deletedOrder = orderService.GetOrderAsync(createdOrder.OrderId).Result;
                    //Console.WriteLine(deleted && deletedOrder == null
                    //    ? "Order was successfully deleted"
                    //    : "Order was not deleted");
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = userService as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }

                // Keep console open
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            
        }

        // Helper methods
        private static void PrintUser(User u)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                u.userId,
                u.firstName,
                u.middleName,
                u.lastName,
                u.email,
                u.socialSecurityNumber,
                u.PersonalInfoId,
                u.employeeId,
                u.applicantId,
                u.applicationId,
                u.userName);
        }

        private static void PrintJob(Job j)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",
                j.jobId,
                j.position,
                j.description,
                j.fullPartTime,
                j.salaryRange,
                j.hoursId,
                j.questionnaireId);
        }

        private static void PrintQuestion(Question q)
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} ",
                q.questionId,
                q.qJsonProperties,
                q.questionnaireId);
        }

        //private static void PrintOrderWithDetails(Order o)
        //{
        //    Console.WriteLine("{0} {1}",
        //        o.OrderId,
        //        o.OrderDate.GetValueOrDefault().ToShortDateString());
        //    foreach (var od in o.OrderDetails)
        //    {
        //        Console.WriteLine("\t{0} {1} {2} {3}",
        //            od.OrderDetailId,
        //            od.Product.ProductName,
        //            od.Quantity,
        //            od.UnitPrice.ToString("c"));
        //    }
        //}
    }
}

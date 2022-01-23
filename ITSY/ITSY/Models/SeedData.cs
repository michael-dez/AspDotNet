using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ITSY.Data;
using System;
using System.Linq;

namespace ITSY.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ITSYContext(serviceProvider.GetRequiredService<DbContextOptions<ITSYContext>>()))
            {
                // Look for any tickets.
                if (context.Ticket.Any())
                {
                    return; // DB has been seeded, do nothing
                }

                context.Ticket.AddRange(
                    new Ticket
                    {
                        Subject = "UI Glitch",
                        Priority = Ticket.PriorityOptions.Low,
                        IssueType = Ticket.IssueTypeOptions.Bug,
                        OpenDate = DateTime.Parse("2020-1-21"),
                        CloseDate = null,
                        Description = "The UI sometimes doesn't look right.",
                        Status = Ticket.StatusOptions.Open
                    },
                    new Ticket
                    {
                        Subject = "Incorrect Date/Time",
                        Priority = Ticket.PriorityOptions.Medium,
                        IssueType = Ticket.IssueTypeOptions.Bug,
                        OpenDate = DateTime.Parse("2020-1-22"),
                        CloseDate = null,
                        Description = "Date and Time showing dates far into the cosmic future.",
                        Status = Ticket.StatusOptions.Open
                    },
                    new Ticket
                    {
                        Subject = "Out of Dog Food",
                        Priority = Ticket.PriorityOptions.High,
                        IssueType = Ticket.IssueTypeOptions.Feature,
                        OpenDate = DateTime.Parse("2020-1-23"),
                        CloseDate = null,
                        Description = "help i am completely out of food i haven't eaten in MINUTES please help me",
                        Status = Ticket.StatusOptions.Open
                    },
                    new Ticket
                    {
                        Subject = "Database Removal",
                        Priority = Ticket.PriorityOptions.Critical,
                        IssueType = Ticket.IssueTypeOptions.Other,
                        OpenDate = DateTime.Parse("2020-1-24"),
                        CloseDate = null,
                        Description = "The entire database has been deleted. God help us.",
                        Status = Ticket.StatusOptions.Open
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
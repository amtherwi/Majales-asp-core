﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Majales.Authorization.Roles;
using Majales.Authorization.Users;
using Majales.MultiTenancy;
using Majales.Models;

namespace Majales.EntityFrameworkCore
{
    public class MajalesDbContext : AbpZeroDbContext<Tenant, Role, User, MajalesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public MajalesDbContext(DbContextOptions<MajalesDbContext> options)
            : base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseLazyLoadingProxies();


        //}

        public DbSet<Majles> Majles { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MajlisMembership> MajlisMembership { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<VoteTransaction> VoteTransactions { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MeetingMinutes> MeetingMinutes { get; set; }
        public DbSet<Attachment> Attachments {get; set;}
        public DbSet<Member> Members { get; set; }
        public DbSet<MembershipRole> MembershipRoles { get; set; }
        public DbSet<MeetingAttendance> Attendances { get; set; }
        public DbSet<MajlesType> MajlesTypes { get; set; }
        public DbSet<TopicClassification> TopicClassifications { get; set; }
        public DbSet<Classification> Classifications { get; set; }

    }
}

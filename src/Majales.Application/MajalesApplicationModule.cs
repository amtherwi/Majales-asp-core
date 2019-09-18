using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Majales.Attachment.DTO;
using Majales.Authorization;
using Majales.Classification.DTO;
using Majales.Comment.DTO;
using Majales.Majles.DTO;
using Majales.MajlesTypes.DTO;
using Majales.MajlisMembership.DTO;
using Majales.Meeting.DTO;
using Majales.MeetingAttendance.DTO;
using Majales.MeetingMinutes.DTO;
using Majales.Member.DTO;
using Majales.MembershipRole.DTO;
using Majales.Models;
using Majales.Topic.DTO;
using Majales.TopicClassification.DTO;
using Majales.Vote.DTO;

namespace Majales
{
    [DependsOn(
        typeof(MajalesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MajalesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MajalesAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateMajlesInput, Models.Majles>().ReverseMap();
                //config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();
                config.CreateMap<UpdateMajlesInput, Models.Majles>().ReverseMap();
                //config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();

                config.CreateMap<CreateMeetingInput, Models.Meeting>().ReverseMap();
                //config.CreateMap<Models.Meeting, GetMeetingOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingInput, Models.Meeting>().ReverseMap();
                //config.CreateMap<Models.Meeting, GetMeetingOutput>().ReverseMap();

                config.CreateMap<CreateClassificationInput, Models.Classification>().ReverseMap();
                //config.CreateMap<Models.Classification, GetClassificationOutput>().ReverseMap();
                config.CreateMap<UpdateClassificationInput, Models.Meeting>().ReverseMap();
                //config.CreateMap<Models.Classification, GetClassificationOutput>().ReverseMap();

                config.CreateMap<CreateAttachmentInput, Models.Attachment>().ReverseMap();
                //config.CreateMap<Models.Attachment, GetAttachmentOutput>().ReverseMap();
                config.CreateMap<UpdateAttachmentInput, Models.Attachment>().ReverseMap();
                //config.CreateMap<Models.Attachment, GetAttachmentOutput>().ReverseMap();

                config.CreateMap<CreateCommentInput, Models.Comment>().ReverseMap();
                //config.CreateMap<Models.Comment, GetCommentOutput>().ReverseMap();
                config.CreateMap<UpdateCommentInput, Models.Comment>().ReverseMap();
                //config.CreateMap<Models.Comment, GetCommentOutput>().ReverseMap();

                config.CreateMap<CreateMajlesTypesInput, Models.MajlesTypes>().ReverseMap();
                //config.CreateMap<Models.MajlesTypes, GetMajlesTypesOutput>().ReverseMap();
                config.CreateMap<UpdateMajlesTypesInput, Models.MajlesTypes>().ReverseMap();
                //config.CreateMap<Models.MajlesTypes, GetMajlesTypesOutput>().ReverseMap();

                config.CreateMap<CreateMajlisMembershipInput, Models.MajlisMembership>().ReverseMap();
                //config.CreateMap<Models.MajlisMembership, GetMajlisMembershipOutput>().ReverseMap();
                config.CreateMap<UpdateMajlisMembershipInput, Models.MajlisMembership>().ReverseMap();
                //config.CreateMap<Models.MajlisMembership, GetMajlisMembershipOutput>().ReverseMap();

                config.CreateMap<CreateMeetingAttendanceInput, Models.MeetingAttendance>().ReverseMap();
                //config.CreateMap<Models.MeetingAttendance, GetMeetingAttendanceOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingAttendanceInput, Models.MeetingAttendance>().ReverseMap();
                //config.CreateMap<Models.MeetingAttendance, GetMeetingAttendanceOutput>().ReverseMap();

                config.CreateMap<CreateMeetingMinutesInput, Models.MeetingMinutes>().ReverseMap();
                //config.CreateMap<Models.MeetingMinutes, GetMeetingMinutesOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingMinutesInput, Models.MeetingMinutes>().ReverseMap();
                //config.CreateMap<Models.MeetingMinutes, GetMeetingMinutesOutput>().ReverseMap();

                config.CreateMap<CreateMemberInput, Models.Member>().ReverseMap();
                //config.CreateMap<Models.Member, GetMemberOutput>().ReverseMap();
                config.CreateMap<UpdateMemberInput, Models.Member>().ReverseMap();
                //config.CreateMap<Models.Member, GetMemberOutput>().ReverseMap();

                config.CreateMap<CreateMembershipRoleInput, Models.MembershipRole>().ReverseMap();
                //config.CreateMap<Models.MembershipRole, GetMembershipRoleOutput>().ReverseMap();
                config.CreateMap<UpdateMembershipRoleInput, Models.MembershipRole>().ReverseMap();
                //config.CreateMap<Models.MembershipRole, GetMembershipRoleOutput>().ReverseMap();

                config.CreateMap<CreateTopicInput, Models.Topic>().ReverseMap();
                //config.CreateMap<Models.Topic, GetTopicOutput>().ReverseMap();
                config.CreateMap<UpdateTopicInput, Models.Topic>().ReverseMap();
                //config.CreateMap<Models.Topic, GetTopicOutput>().ReverseMap();
               
                config.CreateMap< CreateTopicClassificationInput, Models.TopicClassification > ().ReverseMap();
                //config.CreateMap<Models.TopicClassification, GetTopicClassificationOutput> ().ReverseMap();
                config.CreateMap< UpdateTopicClassificationInput, Models.TopicClassification>().ReverseMap();
                //config.CreateMap<Models.TopicClassification, GetTopicClassificationOutput> ().ReverseMap();

                config.CreateMap<CreateVoteInput, Models.Vote>().ReverseMap();
                //config.CreateMap<Models.Vote, GetVoteOutput>().ReverseMap();
                config.CreateMap<UpdateVoteInput, Models.Vote>().ReverseMap();
                //config.CreateMap<Models.Vote, GetVoteOutput>().ReverseMap();

            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MajalesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

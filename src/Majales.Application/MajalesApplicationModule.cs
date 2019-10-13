using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Majales.Attachment.DTO;
using Majales.Authorization;
using Majales.Classification.DTO;
using Majales.Comment.DTO;
using Majales.Majles.DTO;
using Majales.MajlesType.DTO;
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
                #region Models.Majales
                config.CreateMap<CreateMajlesInput, Models.Majles>().ReverseMap();
                config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();
                config.CreateMap<UpdateMajlesInput, Models.Majles>().ReverseMap();
                config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();
                #endregion

                #region Models.Meeting
                config.CreateMap<CreateMeetingInput, Models.Meeting>().ReverseMap();
                config.CreateMap<Models.Meeting, GetMeetingOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingInput, Models.Meeting>().ReverseMap();
                config.CreateMap<Models.Meeting, GetMeetingOutput>().ReverseMap();
                #endregion

                #region Models.Calssification
                config.CreateMap<CreateClassificationInput, Models.Classification>().ReverseMap();
                config.CreateMap<Models.Classification, GetClassificationOutput>().ReverseMap();
                config.CreateMap<UpdateClassificationInput, Models.Meeting>().ReverseMap();
                config.CreateMap<Models.Classification, GetClassificationOutput>().ReverseMap();
                #endregion

                #region Models.Attachment
                config.CreateMap<CreateAttachmentInput, Models.Attachment>().ReverseMap();
                config.CreateMap<Models.Attachment, GetAttachmentOutput>().ReverseMap();
                config.CreateMap<UpdateAttachmentInput, Models.Attachment>().ReverseMap();
                config.CreateMap<Models.Attachment, GetAttachmentOutput>().ReverseMap();
                #endregion

                #region Models.Comment
                config.CreateMap<CreateCommentInput, Models.Comment>().ReverseMap();
                config.CreateMap<Models.Comment, GetCommentOutput>().ReverseMap();
                config.CreateMap<UpdateCommentInput, Models.Comment>().ReverseMap();
                config.CreateMap<Models.Comment, GetCommentOutput>().ReverseMap();
                #endregion

                #region Models.MajalesType
                config.CreateMap<CreateMajlesTypeInput, Models.MajlesType>().ReverseMap();
                config.CreateMap<Models.MajlesType, GetMajlesTypeOutput>().ReverseMap();
                config.CreateMap<UpdateMajlesTypeInput, Models.MajlesType>().ReverseMap();
                config.CreateMap<Models.MajlesType, GetMajlesTypeOutput>().ReverseMap();
                #endregion

                #region Models.MajlisMembership
                config.CreateMap<CreateMajlisMembershipInput, Models.MajlisMembership>().ReverseMap();
                config.CreateMap<Models.MajlisMembership, GetMajlisMembershipOutput>().ReverseMap();
                config.CreateMap<UpdateMajlisMembershipInput, Models.MajlisMembership>().ReverseMap();
                config.CreateMap<Models.MajlisMembership, GetMajlisMembershipOutput>().ReverseMap();
                #endregion

                #region Models.MeetingAttendance
                config.CreateMap<CreateMeetingAttendanceInput, Models.MeetingAttendance>().ReverseMap();
                config.CreateMap<Models.MeetingAttendance, GetMeetingAttendanceOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingAttendanceInput, Models.MeetingAttendance>().ReverseMap();
                config.CreateMap<Models.MeetingAttendance, GetMeetingAttendanceOutput>().ReverseMap();
                #endregion

                #region Models.MeetingMinutes
                config.CreateMap<CreateMeetingMinutesInput, Models.MeetingMinutes>().ReverseMap();
                config.CreateMap<Models.MeetingMinutes, GetMeetingMinutesOutput>().ReverseMap();
                config.CreateMap<UpdateMeetingMinutesInput, Models.MeetingMinutes>().ReverseMap();
                config.CreateMap<Models.MeetingMinutes, GetMeetingMinutesOutput>().ReverseMap();
                #endregion

                #region Models.Member
                config.CreateMap<CreateMemberInput, Models.Member>().ReverseMap();
                config.CreateMap<Models.Member, GetMemberOutput>().ReverseMap();
                config.CreateMap<UpdateMemberInput, Models.Member>().ReverseMap();
                config.CreateMap<Models.Member, GetMemberOutput>().ReverseMap();
                #endregion

                #region Models.MembershipRole
                config.CreateMap<CreateMembershipRoleInput, Models.MembershipRole>().ReverseMap();
                config.CreateMap<Models.MembershipRole, GetMembershipRoleOutput>().ReverseMap();
                config.CreateMap<UpdateMembershipRoleInput, Models.MembershipRole>().ReverseMap();
                config.CreateMap<Models.MembershipRole, GetMembershipRoleOutput>().ReverseMap();
                #endregion

                #region Models.Topic
                config.CreateMap<CreateTopicInput, Models.Topic>().ReverseMap();
                config.CreateMap<Models.Topic, GetTopicOutput>().ReverseMap();
                config.CreateMap<UpdateTopicInput, Models.Topic>().ReverseMap();
                config.CreateMap<Models.Topic, GetTopicOutput>().ReverseMap();
                #endregion

                #region Models.TopicClassification
                config.CreateMap<CreateTopicClassificationInput, Models.TopicClassification>().ReverseMap();
                config.CreateMap<Models.TopicClassification, GetTopicClassificationOutput>().ReverseMap();
                config.CreateMap<UpdateTopicClassificationInput, Models.TopicClassification>().ReverseMap();
                config.CreateMap<Models.TopicClassification, GetTopicClassificationOutput>().ReverseMap();
                #endregion

                #region Models.Vote
                config.CreateMap<CreateVoteInput, Models.Vote>().ReverseMap();
                config.CreateMap<Models.Vote, GetVoteOutput>().ReverseMap();
                config.CreateMap<UpdateVoteInput, Models.Vote>().ReverseMap();
                config.CreateMap<Models.Vote, GetVoteOutput>().ReverseMap();
                #endregion
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

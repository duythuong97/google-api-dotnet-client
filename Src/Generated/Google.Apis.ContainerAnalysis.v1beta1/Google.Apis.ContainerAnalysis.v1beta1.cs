// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.ContainerAnalysis.v1beta1
{
    /// <summary>The ContainerAnalysis Service.</summary>
    public class ContainerAnalysisService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ContainerAnalysisService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ContainerAnalysisService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "containeranalysis";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://containeranalysis.googleapis.com/";
        #else
            "https://containeranalysis.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://containeranalysis.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Container Analysis API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Container Analysis API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for ContainerAnalysis requests.</summary>
    public abstract class ContainerAnalysisBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ContainerAnalysisBaseServiceRequest instance.</summary>
        protected ContainerAnalysisBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ContainerAnalysis parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Notes = new NotesResource(service);
            Occurrences = new OccurrencesResource(service);
            ScanConfigs = new ScanConfigsResource(service);

        }

        /// <summary>Gets the Notes resource.</summary>
        public virtual NotesResource Notes { get; }

        /// <summary>The "notes" collection of methods.</summary>
        public class NotesResource
        {
            private const string Resource = "notes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Occurrences = new OccurrencesResource(service);

            }

            /// <summary>Gets the Occurrences resource.</summary>
            public virtual OccurrencesResource Occurrences { get; }

            /// <summary>The "occurrences" collection of methods.</summary>
            public class OccurrencesResource
            {
                private const string Resource = "occurrences";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OccurrencesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Lists occurrences referencing the specified note. Provider projects can use this method to
                /// get all occurrences across consumer projects referencing the specified note.</summary>
                /// <param name="name">Required. The name of the note to list occurrences for in the form of
                /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>Lists occurrences referencing the specified note. Provider projects can use this method to
                /// get all occurrences across consumer projects referencing the specified note.</summary>
                public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListNoteOccurrencesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the note to list occurrences for in the form of
                    /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The filter expression.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Number of occurrences to return in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}/occurrences";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/notes/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }
            }

            /// <summary>Creates new notes in batch.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the notes
            /// are to be created.</param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>Creates new notes in batch.</summary>
            public class BatchCreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
                /// notes are to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateNotesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Creates a new note.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the note
            /// is to be created.</param>
            public virtual CreateRequest Create(Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new note.</summary>
            public class CreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
                /// note is to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. The ID to use for this note.</summary>
                [Google.Apis.Util.RequestParameterAttribute("noteId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string NoteId { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Note Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("noteId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "noteId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Deletes the specified note.</summary>
            /// <param name="name">Required. The name of the note in the form of
            /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified note.</summary>
            public class DeleteRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the note in the form of
                /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }

            }

            /// <summary>Gets the specified note.</summary>
            /// <param name="name">Required. The name of the note in the form of
            /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified note.</summary>
            public class GetRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the note in the form of
                /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }

            }

            /// <summary>Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class GetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }

            }

            /// <summary>Lists notes for the specified project.</summary>
            /// <param name="parent">Required. The name of the project to list notes for in the form of
            /// `projects/[PROJECT_ID]`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notes for the specified project.</summary>
            public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListNotesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. The name of the project to list notes for in the form of
                /// `projects/[PROJECT_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Number of notes to return in the list. Must be positive. Max allowed page size is 1000. If
                /// not specified, page size defaults to 20.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/notes";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Updates the specified note.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the note in the form of
            /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</param>
            public virtual PatchRequest Patch(Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified note.</summary>
            public class PatchRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Note body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the note in the form of
                /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Note Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class SetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }

            }

            /// <summary>Returns the permissions that a caller has on the specified note or occurrence. Requires list
            /// permission on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns the permissions that a caller has on the specified note or occurrence. Requires list
            /// permission on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class TestIamPermissionsRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notes/[^/]+$",
                    });
                }

            }
        }
        /// <summary>Gets the Occurrences resource.</summary>
        public virtual OccurrencesResource Occurrences { get; }

        /// <summary>The "occurrences" collection of methods.</summary>
        public class OccurrencesResource
        {
            private const string Resource = "occurrences";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public OccurrencesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates new occurrences in batch.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
            /// occurrences are to be created.</param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>Creates new occurrences in batch.</summary>
            public class BatchCreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
                /// occurrences are to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.BatchCreateOccurrencesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Creates a new occurrence.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
            /// occurrence is to be created.</param>
            public virtual CreateRequest Create(Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new occurrence.</summary>
            public class CreateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in the form of `projects/[PROJECT_ID]`, under which the
                /// occurrence is to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }

            }

            /// <summary>Deletes the specified occurrence. For example, use this method to delete an occurrence when the
            /// occurrence is no longer applicable for the given resource.</summary>
            /// <param name="name">Required. The name of the occurrence in the form of
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified occurrence. For example, use this method to delete an occurrence when the
            /// occurrence is no longer applicable for the given resource.</summary>
            public class DeleteRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }

            /// <summary>Gets the specified occurrence.</summary>
            /// <param name="name">Required. The name of the occurrence in the form of
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified occurrence.</summary>
            public class GetRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }

            /// <summary>Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Gets the access control policy for a note or an occurrence resource. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class GetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }

            /// <summary>Gets the note attached to the specified occurrence. Consumer projects can use this method to
            /// get a note that belongs to a provider project.</summary>
            /// <param name="name">Required. The name of the occurrence in the form of
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</param>
            public virtual GetNotesRequest GetNotes(string name)
            {
                return new GetNotesRequest(service, name);
            }

            /// <summary>Gets the note attached to the specified occurrence. Consumer projects can use this method to
            /// get a note that belongs to a provider project.</summary>
            public class GetNotesRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Note>
            {
                /// <summary>Constructs a new GetNotes request.</summary>
                public GetNotesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getNotes";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}/notes";

                /// <summary>Initializes GetNotes parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }

            /// <summary>Gets a summary of the number and severity of occurrences.</summary>
            /// <param name="parent">Required. The name of the project to get a vulnerability summary for in the form of
            /// `projects/[PROJECT_ID]`.</param>
            public virtual GetVulnerabilitySummaryRequest GetVulnerabilitySummary(string parent)
            {
                return new GetVulnerabilitySummaryRequest(service, parent);
            }

            /// <summary>Gets a summary of the number and severity of occurrences.</summary>
            public class GetVulnerabilitySummaryRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.VulnerabilityOccurrencesSummary>
            {
                /// <summary>Constructs a new GetVulnerabilitySummary request.</summary>
                public GetVulnerabilitySummaryRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. The name of the project to get a vulnerability summary for in the form of
                /// `projects/[PROJECT_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getVulnerabilitySummary";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences:vulnerabilitySummary";

                /// <summary>Initializes GetVulnerabilitySummary parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Lists occurrences for the specified project.</summary>
            /// <param name="parent">Required. The name of the project to list occurrences for in the form of
            /// `projects/[PROJECT_ID]`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists occurrences for the specified project.</summary>
            public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListOccurrencesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. The name of the project to list occurrences for in the form of
                /// `projects/[PROJECT_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Number of occurrences to return in the list. Must be positive. Max allowed page size is
                /// 1000. If not specified, page size defaults to 20.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/occurrences";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Updates the specified occurrence.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the occurrence in the form of
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</param>
            public virtual PatchRequest Patch(Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified occurrence.</summary>
            public class PatchRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the occurrence in the form of
                /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.Occurrence Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified note or occurrence. Requires
            /// `containeranalysis.notes.setIamPolicy` or `containeranalysis.occurrences.setIamPolicy` permission if the
            /// resource is a note or an occurrence, respectively. The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class SetIamPolicyRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }

            /// <summary>Returns the permissions that a caller has on the specified note or occurrence. Requires list
            /// permission on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns the permissions that a caller has on the specified note or occurrence. Requires list
            /// permission on the project (for example, `containeranalysis.notes.list`). The resource takes the format
            /// `projects/[PROJECT_ID]/notes/[NOTE_ID]` for notes and
            /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for occurrences.</summary>
            public class TestIamPermissionsRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/occurrences/[^/]+$",
                    });
                }

            }
        }
        /// <summary>Gets the ScanConfigs resource.</summary>
        public virtual ScanConfigsResource ScanConfigs { get; }

        /// <summary>The "scanConfigs" collection of methods.</summary>
        public class ScanConfigsResource
        {
            private const string Resource = "scanConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ScanConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets the specified scan configuration.</summary>
            /// <param name="name">Required. The name of the scan configuration in the form of
            /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the specified scan configuration.</summary>
            public class GetRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ScanConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. The name of the scan configuration in the form of
                /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                }

            }

            /// <summary>Lists scan configurations for the specified project.</summary>
            /// <param name="parent">Required. The name of the project to list scan configurations for in the form of
            /// `projects/[PROJECT_ID]`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists scan configurations for the specified project.</summary>
            public class ListRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ListScanConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. The name of the project to list scan configurations for in the form of
                /// `projects/[PROJECT_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. The filter expression.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The number of scan configs to return in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/scanConfigs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }

            /// <summary>Updates the specified scan configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the scan configuration in the form of
            /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.</param>
            public virtual UpdateRequest Update(Google.Apis.ContainerAnalysis.v1beta1.Data.ScanConfig body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>Updates the specified scan configuration.</summary>
            public class UpdateRequest : ContainerAnalysisBaseServiceRequest<Google.Apis.ContainerAnalysis.v1beta1.Data.ScanConfig>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.ContainerAnalysis.v1beta1.Data.ScanConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the scan configuration in the form of
                /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ContainerAnalysis.v1beta1.Data.ScanConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/scanConfigs/[^/]+$",
                    });
                }

            }
        }
    }
}

namespace Google.Apis.ContainerAnalysis.v1beta1.Data
{    

    /// <summary>An alias to a repo revision.</summary>
    public class AliasContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alias kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Artifact describes a build product.</summary>
    public class Artifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash or checksum value of a binary, or Docker Registry 2.0 digest of a container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual string Checksum { get; set; }

        /// <summary>Artifact ID, if any; for container images, this will be a URL by digest like
        /// `gcr.io/projectID/imagename@sha256:123456`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Related artifact names. This may be the path to a binary or jar file, or in the case of a container
        /// build, the name used to push the container image to Google Container Registry, as presented to `docker
        /// push`. Note that a single Artifact ID can have multiple names, for example if two tags are applied to one
        /// image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines a hash object for use in Materials and Products.</summary>
    public class ArtifactHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an object to declare an in-toto artifact rule</summary>
    public class ArtifactRule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("artifactRule")]
        public virtual System.Collections.Generic.IList<string> ArtifactRuleValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Occurrence that represents a single "attestation". The authenticity of an attestation can be verified
    /// using the attached signature. If the verifier trusts the public key of the signer, then verifying the signature
    /// is sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is
    /// primarily useful for look-up (how to find this attestation if you already know the authority and artifact to be
    /// verified) and intent (which authority was this attestation intended to sign for).</summary>
    public class Attestation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("genericSignedAttestation")]
        public virtual GenericSignedAttestation GenericSignedAttestation { get; set; }

        /// <summary>A PGP signed attestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pgpSignedAttestation")]
        public virtual PgpSignedAttestation PgpSignedAttestation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization
    /// might have one `Authority` for "QA" and one for "build". This note is intended to act strictly as a grouping
    /// mechanism for the attached occurrences (Attestations). This grouping mechanism also provides a security
    /// boundary, since IAM ACLs gate the ability for a principle to attach an occurrence to a given note. It also
    /// provides a single point of lookup to find all attached attestation occurrences, even if they don't all live in
    /// the same project.</summary>
    public class Authority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hint hints at the purpose of the attestation authority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hint")]
        public virtual Hint Hint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Basis describes the base image portion (Note) of the DockerImage relationship. Linked occurrences are
    /// derived from this or an equivalent image via: FROM Or an equivalent reference, e.g. a tag of the
    /// resource_url.</summary>
    public class Basis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The fingerprint of the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual Fingerprint Fingerprint { get; set; }

        /// <summary>Required. Immutable. The resource_url for the resource representing the basis of associated
        /// occurrence images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request to create notes in batch.</summary>
    public class BatchCreateNotesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The notes to create. Max allowed length is 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IDictionary<string, Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for creating notes in batch.</summary>
    public class BatchCreateNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The notes that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request to create occurrences in batch.</summary>
    public class BatchCreateOccurrencesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The occurrences to create. Max allowed length is 1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for creating occurrences in batch.</summary>
    public class BatchCreateOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The occurrences that were created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bindingId")]
        public virtual string BindingId { get; set; }

        /// <summary>The condition that is associated with this binding. If the condition evaluates to `true`, then this
        /// binding applies to the current request. If the condition evaluates to `false`, then this binding does not
        /// apply to the current request. However, a different role binding might grant the same role to one or more of
        /// the members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or
        /// without a Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is
        /// authenticated with a Google account or a service account. * `user:{emailid}`: An email address that
        /// represents a specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An
        /// email address that represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example, `my-other-
        /// app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value
        /// reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding. *
        /// `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google
        /// group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the
        /// group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the
        /// binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For
        /// example, `google.com` or `example.com`. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Note holding the version of the provider's builder and the signature of the provenance message in the
    /// build details occurrence.</summary>
    public class Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Version of the builder which produced this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderVersion")]
        public virtual string BuilderVersion { get; set; }

        /// <summary>Signature of the build in occurrences pointing to this build note containing build
        /// details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual BuildSignature Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provenance of a build. Contains all information needed to verify the full details about the build from
    /// source to completion.</summary>
    public class BuildProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Special options applied to this build. This is a catch-all field where build providers can enter
        /// any desired additional details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> BuildOptions { get; set; }

        /// <summary>Version string of the builder at the time this build was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderVersion")]
        public virtual string BuilderVersion { get; set; }

        /// <summary>Output of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtArtifacts")]
        public virtual System.Collections.Generic.IList<Artifact> BuiltArtifacts { get; set; }

        /// <summary>Commands requested by the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<Command> Commands { get; set; }

        /// <summary>Time at which the build was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>E-mail address of the user who initiated this build. Note that this was the user's e-mail address
        /// at the time the build was initiated; this address may not represent the same end-user for all
        /// time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Time at which execution of the build was finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URI where any logs for this provenance were written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsUri")]
        public virtual string LogsUri { get; set; }

        /// <summary>ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Details of the Source input to the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual Source SourceProvenance { get; set; }

        /// <summary>Time at which execution of the build was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Trigger identifier if the build was triggered automatically; empty if not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Message encapsulating the signature of the verified build.</summary>
    public class BuildSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An ID for the key used to sign. This could be either an ID for the key stored in `public_key` (such
        /// as the ID or fingerprint for a PGP key, or the CN for a cert), or a reference to an external key (such as a
        /// reference to a key in Cloud Key Management Service).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>The type of the key, either stored in `public_key` or referenced in `key_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>Public key of the builder which can be used to verify that the related findings are valid and
        /// unchanged. If `key_type` is empty, this defaults to PEM encoded public keys. This field may be empty if
        /// `key_id` references an external key. For Cloud Build based signatures, this is a PEM encoded public key. To
        /// verify the Cloud Build signature, place the contents of this field into a file (public.pem). The signature
        /// field is base64-decoded into its binary representation in signature.bin, and the provenance bytes from
        /// `BuildDetails` are base64-decoded into a binary representation in signed.bin. OpenSSL can then verify the
        /// signature: `openssl sha256 -verify public.pem -signature signature.bin signed.bin`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>Required. Signature of the related `BuildProvenance`. In JSON, this is base-64 encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an object for the byproducts field in in-toto links. The suggested fields are "stderr",
    /// "stdout", and "return-value".</summary>
    public class ByProducts : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customValues")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Common Vulnerability Scoring System version 3. For details, see https://www.first.org/cvss
    /// /specification-document</summary>
    public class CVSSv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over
        /// time and across user environments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<float> BaseScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exploitabilityScore")]
        public virtual System.Nullable<float> ExploitabilityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impactScore")]
        public virtual System.Nullable<float> ImpactScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A CloudRepoSourceContext denotes a particular revision in a Google Cloud Source Repo.</summary>
    public class CloudRepoSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The ID of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual RepoId RepoId { get; set; }

        /// <summary>A revision ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Command describes a step performed as part of the build pipeline.</summary>
    public class Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Command-line arguments used when executing this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Working directory (relative to project source root) used when running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Environment variables set before running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Optional unique identifier for this command, used in wait_for to reference this command as a
        /// dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. Name of the command, as presented on the command line, or if the command is packaged as a
        /// Docker container, as presented to `docker pull`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID(s) of the command(s) that this command depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An artifact that can be deployed in some runtime.</summary>
    public class Deployable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Resource URI for the artifact being deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual System.Collections.Generic.IList<string> ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The period during which some deployable was active in a runtime.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Address of the runtime element hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Configuration used to create this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        /// <summary>Required. Beginning of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployTime")]
        public virtual object DeployTime { get; set; }

        /// <summary>Platform hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Output only. Resource URI for the artifact being deployed taken from the deployable field with the
        /// same name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual System.Collections.Generic.IList<string> ResourceUri { get; set; }

        /// <summary>End of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeployTime")]
        public virtual object UndeployTime { get; set; }

        /// <summary>Identity of the user that triggered this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Derived describes the derived image portion (Occurrence) of the DockerImage relationship. This image
    /// would be produced from a Dockerfile with FROM .</summary>
    public class Derived : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This contains the base image URL for the derived image occurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseResourceUrl")]
        public virtual string BaseResourceUrl { get; set; }

        /// <summary>Output only. The number of layers by which this image differs from the associated image
        /// basis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual System.Nullable<int> Distance { get; set; }

        /// <summary>Required. The fingerprint of the derived image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual Fingerprint Fingerprint { get; set; }

        /// <summary>This contains layer-specific metadata, if populated it has length "distance" and is ordered with
        /// [distance] being the layer immediately following the base image and [1] being the final layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerInfo")]
        public virtual System.Collections.Generic.IList<Layer> LayerInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Identifies all appearances of this vulnerability in the package for a specific distro/location. For
    /// example: glibc in cpe:/o:debian:debian_linux:8 for versions 2.1 - 2.2</summary>
    public class Detail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) in which the
        /// vulnerability manifests. Examples include distro or storage location for vulnerable jar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>A vendor-specific description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The fix for this specific package version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedLocation")]
        public virtual VulnerabilityLocation FixedLocation { get; set; }

        /// <summary>Whether this detail is obsolete. Occurrences are expected not to point to obsolete
        /// details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isObsolete")]
        public virtual System.Nullable<bool> IsObsolete { get; set; }

        /// <summary>The max version of the package in which the vulnerability exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAffectedVersion")]
        public virtual Version MaxAffectedVersion { get; set; }

        /// <summary>The min version of the package in which the vulnerability exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAffectedVersion")]
        public virtual Version MinAffectedVersion { get; set; }

        /// <summary>Required. The name of the package where the vulnerability was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>The type of package; whether native or non native(ruby gems, node.js packages etc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The severity (eg: distro assigned severity) for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityName")]
        public virtual string SeverityName { get; set; }

        /// <summary>The time this information was last changed at the source. This is an upstream timestamp from the
        /// underlying information source - e.g. Ubuntu security tracker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUpdateTime")]
        public virtual object SourceUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of an attestation occurrence.</summary>
    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Attestation for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual Attestation Attestation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Provides information about the analysis status of a discovered resource.</summary>
    public class Discovered : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of discovery for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatus")]
        public virtual string AnalysisStatus { get; set; }

        /// <summary>When an error is encountered this will contain a LocalizedMessage under details to show to the
        /// user. The LocalizedMessage is output only and populated by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatusError")]
        public virtual Status AnalysisStatusError { get; set; }

        /// <summary>Whether the resource is continuously analyzed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousAnalysis")]
        public virtual string ContinuousAnalysis { get; set; }

        /// <summary>The last time continuous analysis was done for this resource. Deprecated, do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAnalysisTime")]
        public virtual object LastAnalysisTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A note that indicates a type of analysis a provider would perform. This note exists in a provider's
    /// project. A `Discovery` occurrence is created in a consumer's project at the start of analysis.</summary>
    public class Discovery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The kind of analysis that is handled by this discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisKind")]
        public virtual string AnalysisKind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This represents a particular channel of distribution for a given package. E.g., Debian's jessie-
    /// backports dpkg mirror.</summary>
    public class Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPU architecture for which packages in this distribution channel were built.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Required. The cpe_uri in [CPE format](https://cpe.mitre.org/specification/) denoting the package
        /// manager version distributing a package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The distribution channel-specific description of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The latest available version of this package in this distribution channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestVersion")]
        public virtual Version LatestVersion { get; set; }

        /// <summary>A freeform string denoting the maintainer of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintainer")]
        public virtual string Maintainer { get; set; }

        /// <summary>The distribution channel-specific homepage for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines an object for the environment field in in-toto links. The suggested fields are "variables",
    /// "filesystem", and "workdir".</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customValues")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like
    /// expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec.
    /// Example (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() < 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' && document.type != 'internal'" Example (Data Manipulation):
    /// title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New
    /// message received at ' + string(document.create_time)" The exact variables and functions that may be referenced
    /// within an expression are determined by the service that evaluates it. See the service documentation for
    /// additional information.</summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g.
        /// when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container message for hashes of byte content of files, used in source messages to verify integrity of
    /// source input to the build.</summary>
    public class FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A set of properties that uniquely identify a given Docker image.</summary>
    public class Fingerprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The layer ID of the final layer in the Docker image's v1 representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1Name")]
        public virtual string V1Name { get; set; }

        /// <summary>Required. The ordered list of v2 blobs that represent a given image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Blob")]
        public virtual System.Collections.Generic.IList<string> V2Blob { get; set; }

        /// <summary>Output only. The name of the image's v2 blobs computed via: [bottom] := v2_blobbottom :=
        /// sha256(v2_blob[N] + " " + v2_name[N+1]) Only the name of the final blob is kept.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Name")]
        public virtual string V2Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Per resource and severity counts of fixable and total vulnerabilities.</summary>
    public class FixableTotalByDigest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of fixable vulnerabilities associated with this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixableCount")]
        public virtual System.Nullable<long> FixableCount { get; set; }

        /// <summary>The affected resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>The severity for this count. SEVERITY_UNSPECIFIED indicates total across all severities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The total number of vulnerabilities associated with this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<long> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An attestation wrapper that uses the Grafeas `Signature` message. This attestation must define the
    /// `serialized_payload` that the `signatures` verify and any metadata necessary to interpret that plaintext. The
    /// signatures should always be over the `serialized_payload` bytestring.</summary>
    public class GenericSignedAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type (for example schema) of the attestation payload that was signed. The verifier must ensure that
        /// the provided type is one that the verifier supports, and that the attestation payload is a valid
        /// instantiation of that type (for example by validating a JSON schema).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The serialized payload that is verified by one or more `signatures`. The encoding and semantic
        /// meaning of this payload must match what is set in `content_type`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedPayload")]
        public virtual string SerializedPayload { get; set; }

        /// <summary>One or more signatures over `serialized_payload`. Verifier implementations should consider this
        /// attestation message verified if at least one `signature` verifies `serialized_payload`. See `Signature` in
        /// common.proto for more details on signature structure and verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<Signature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A SourceContext referring to a Gerrit project.</summary>
    public class GerritSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The full project name within the host. Projects may be nested, so "project/subproject" is a valid
        /// project name. The "repo name" is the hostURI/project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerritProject")]
        public virtual string GerritProject { get; set; }

        /// <summary>The URI of a running Gerrit instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>A revision (commit) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
        /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings must
        /// specify version 3. Policies without any conditional bindings may specify any valid value or leave the field
        /// unset. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A GitSourceContext denotes a particular revision in a third party Git repository (e.g.,
    /// GitHub).</summary>
    public class GitSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Git commit hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Git repository URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata for all operations used and required for all operations that created by Container Analysis
    /// Providers</summary>
    public class GoogleDevtoolsContaineranalysisV1alpha1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time this operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time that this operation was marked completed or failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a build occurrence.</summary>
    public class GrafeasV1beta1BuildDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The actual provenance for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual BuildProvenance Provenance { get; set; }

        /// <summary>Serialized JSON representation of the provenance, used in generating the build signature in the
        /// corresponding build note. After verifying the signature, `provenance_bytes` can be unmarshalled and compared
        /// to the provenance to confirm that it is unchanged. A base64-encoded string representation of the provenance
        /// bytes is used for the signature in order to interoperate with openssl which expects this format for
        /// signature verification. The serialized form is captured both to avoid ambiguity in how the provenance is
        /// marshalled to json as well to prevent incompatibilities with future changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenanceBytes")]
        public virtual string ProvenanceBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a deployment occurrence.</summary>
    public class GrafeasV1beta1DeploymentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Deployment history for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual Deployment Deployment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a discovery occurrence.</summary>
    public class GrafeasV1beta1DiscoveryDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Analysis status for the discovered resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovered")]
        public virtual Discovered Discovered { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of an image occurrence.</summary>
    public class GrafeasV1beta1ImageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The child image derived from the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedImage")]
        public virtual Derived DerivedImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GrafeasV1beta1IntotoArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("hashes")]
        public virtual ArtifactHashes Hashes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This corresponds to a signed in-toto link - it is made up of one or more signatures and the in-toto
    /// link itself. This is used for occurrences of a Grafeas in-toto note.</summary>
    public class GrafeasV1beta1IntotoDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoSignature> Signatures { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signed")]
        public virtual Link Signed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A signature object consists of the KeyID used and the signature itself.</summary>
    public class GrafeasV1beta1IntotoSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("keyid")]
        public virtual string Keyid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sig")]
        public virtual string Sig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a package occurrence.</summary>
    public class GrafeasV1beta1PackageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Where the package was installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual Installation Installation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details of a vulnerability Occurrence.</summary>
    public class GrafeasV1beta1VulnerabilityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The CVSS score of this vulnerability. CVSS score is on a scale of 0-10 where 0
        /// indicates low severity and 10 indicates high severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScore")]
        public virtual System.Nullable<float> CvssScore { get; set; }

        /// <summary>The distro assigned severity for this vulnerability when it is available, and note provider
        /// assigned severity when distro has not yet assigned a severity for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSeverity")]
        public virtual string EffectiveSeverity { get; set; }

        /// <summary>Output only. A detailed description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>Required. The set of affected locations and their fixes (if available) within the associated
        /// resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageIssue")]
        public virtual System.Collections.Generic.IList<PackageIssue> PackageIssue { get; set; }

        /// <summary>Output only. URLs related to this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUrls")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUrls { get; set; }

        /// <summary>Output only. The note provider assigned Severity of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. A one sentence description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>The type of package; whether native or non native(ruby gems, node.js packages etc)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Container message for hash values.</summary>
    public class Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This submessage provides human-readable hints about the purpose of the authority. Because the name of a
    /// note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might
    /// be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints
    /// should not be used to look up authorities in security sensitive contexts, such as when looking up attestations
    /// to verify.</summary>
    public class Hint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The human readable name of this attestation authority, for example "qa".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReadableName")]
        public virtual string HumanReadableName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This contains the fields corresponding to the definition of a software supply chain step in an in-toto
    /// layout. This information goes into a Grafeas note.</summary>
    public class InToto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field contains the expected command used to perform the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedCommand")]
        public virtual System.Collections.Generic.IList<string> ExpectedCommand { get; set; }

        /// <summary>The following fields contain in-toto artifact rules identifying the artifacts that enter this
        /// supply chain step, and exit the supply chain step, i.e. materials and products of the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedMaterials")]
        public virtual System.Collections.Generic.IList<ArtifactRule> ExpectedMaterials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expectedProducts")]
        public virtual System.Collections.Generic.IList<ArtifactRule> ExpectedProducts { get; set; }

        /// <summary>This field contains the public keys that can be used to verify the signatures on the step
        /// metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingKeys")]
        public virtual System.Collections.Generic.IList<SigningKey> SigningKeys { get; set; }

        /// <summary>This field identifies the name of the step in the supply chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepName")]
        public virtual string StepName { get; set; }

        /// <summary>This field contains a value that indicates the minimum number of keys that need to be used to sign
        /// the step's in-toto link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<long> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This represents how a particular software package may be installed on a system.</summary>
    public class Installation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. All of the places within the filesystem versions of this package have been
        /// found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual System.Collections.Generic.IList<Location> Location { get; set; }

        /// <summary>Output only. The name of the installed package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class KnowledgeBase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The KB name (generally of the form KB[0-9]+ i.e. KB123456).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A link to the KB in the Windows update catalog -
        /// https://www.catalog.update.microsoft.com/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Layer holds metadata specific to a layer of a Docker image.</summary>
    public class Layer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recovered arguments to the Dockerfile directive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual string Arguments { get; set; }

        /// <summary>Required. The recovered Dockerfile directive used to construct this layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directive")]
        public virtual string Directive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This corresponds to an in-toto link.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ByProducts are data generated as part of a software supply chain step, but are not the actual
        /// result of the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byproducts")]
        public virtual ByProducts Byproducts { get; set; }

        /// <summary>This field contains the full command executed for the step. This can also be empty if links are
        /// generated for operations that aren't directly mapped to a specific command. Each term in the command is an
        /// independent string in the list. An example of a command in the in-toto metadata field is: "command": ["git",
        /// "clone", "https://github.com/in-toto/demo-project.git"]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>This is a field that can be used to capture information about the environment. It is suggested for
        /// this field to contain information that details environment variables, filesystem information, and the
        /// present working directory. The recommended structure of this field is: "environment": { "custom_values": {
        /// "variables": "", "filesystem": "", "workdir": "", "": "..." } }</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>Materials are the supply chain artifacts that go into the step and are used for the operation
        /// performed. The key of the map is the path of the artifact and the structure contains the recorded hash
        /// information. An example is: "materials": [ { "resource_uri": "foo/bar", "hashes": { "sha256": "ebebf...", :
        /// } } ]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoArtifact> Materials { get; set; }

        /// <summary>Products are the supply chain artifacts generated as a result of the step. The structure is
        /// identical to that of materials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GrafeasV1beta1IntotoArtifact> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for listing occurrences for a note.</summary>
    public class ListNoteOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to provide to skip to a particular spot in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The occurrences attached to the specified note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for listing notes.</summary>
    public class ListNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next pagination token in the list response. It should be used as `page_token` for the following
        /// request. An empty value means no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The notes requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for listing occurrences.</summary>
    public class ListOccurrencesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next pagination token in the list response. It should be used as `page_token` for the following
        /// request. An empty value means no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The occurrences requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for listing scan configurations.</summary>
    public class ListScanConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next pagination token in the list response. It should be used as `page_token` for the following
        /// request. An empty value means no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The scan configurations requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanConfigs")]
        public virtual System.Collections.Generic.IList<ScanConfig> ScanConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An occurrence of a particular package installation found within a system's filesystem. E.g., glibc was
    /// found in `/var/lib/dpkg/status`.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CPE URI in [CPE format](https://cpe.mitre.org/specification/) denoting the package
        /// manager version distributing a package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The path from which we gathered that this package/version is installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The version installed at this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A type of analysis that can be done for a resource.</summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A note describing an attestation role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationAuthority")]
        public virtual Authority AttestationAuthority { get; set; }

        /// <summary>A note describing a base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImage")]
        public virtual Basis BaseImage { get; set; }

        /// <summary>A note describing build provenance for a verifiable build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual Build Build { get; set; }

        /// <summary>Output only. The time this note was created. This field can be used as a filter in list
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A note describing something that can be deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployable")]
        public virtual Deployable Deployable { get; set; }

        /// <summary>A note describing the initial analysis of a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovery")]
        public virtual Discovery Discovery { get; set; }

        /// <summary>Time of expiration for this note. Empty if note does not expire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual object ExpirationTime { get; set; }

        /// <summary>A note describing an in-toto link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intoto")]
        public virtual InToto Intoto { get; set; }

        /// <summary>Output only. The type of analysis. This field can be used as a filter in list requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A detailed description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>Output only. The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A note describing a package hosted by various package managers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual Package Package { get; set; }

        /// <summary>Other notes related to this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedNoteNames")]
        public virtual System.Collections.Generic.IList<string> RelatedNoteNames { get; set; }

        /// <summary>URLs associated with this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUrl")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUrl { get; set; }

        /// <summary>A one sentence description of this note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>Output only. The time this note was last updated. This field can be used as a filter in list
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>A note describing a package vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An instance of an analysis type that has been found on a resource.</summary>
    public class Occurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes an attestation of an artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual Details Attestation { get; set; }

        /// <summary>Describes a verifiable build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual GrafeasV1beta1BuildDetails Build { get; set; }

        /// <summary>Output only. The time this occurrence was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Describes the deployment of an artifact on a runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual GrafeasV1beta1DeploymentDetails Deployment { get; set; }

        /// <summary>Describes how this resource derives from the basis in the associated note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedImage")]
        public virtual GrafeasV1beta1ImageDetails DerivedImage { get; set; }

        /// <summary>Describes when a resource was discovered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovered")]
        public virtual GrafeasV1beta1DiscoveryDetails Discovered { get; set; }

        /// <summary>Describes the installation of a package on the linked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual GrafeasV1beta1PackageDetails Installation { get; set; }

        /// <summary>Describes a specific in-toto link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intoto")]
        public virtual GrafeasV1beta1IntotoDetails Intoto { get; set; }

        /// <summary>Output only. This explicitly denotes which of the occurrence details are specified. This field can
        /// be used as a filter in list requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. The analysis note associated with this occurrence, in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`. This field can be used as a filter in list requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteName")]
        public virtual string NoteName { get; set; }

        /// <summary>A description of actions that can be taken to remedy the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>Required. Immutable. The resource for which the occurrence applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>Output only. The time this occurrence was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Describes a security vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual GrafeasV1beta1VulnerabilityDetails Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This represents a particular package that is distributed over various channels. E.g., glibc (aka libc6)
    /// is distributed by many, at various versions.</summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The various channels by which a package is distributed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual System.Collections.Generic.IList<Distribution> Distribution { get; set; }

        /// <summary>Required. Immutable. The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This message wraps a location affected by a vulnerability and its associated fix (if one is
    /// available).</summary>
    public class PackageIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedLocation")]
        public virtual VulnerabilityLocation AffectedLocation { get; set; }

        /// <summary>The location of the available fix for vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedLocation")]
        public virtual VulnerabilityLocation FixedLocation { get; set; }

        /// <summary>Deprecated, use Details.effective_severity instead The severity (e.g., distro assigned severity)
        /// for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityName")]
        public virtual string SeverityName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An attestation wrapper with a PGP-compatible signature. This message only supports `ATTACHED`
    /// signatures, where the payload that is signed is included alongside the signature itself in the same
    /// file.</summary>
    public class PgpSignedAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type (for example schema) of the attestation payload that was signed. The verifier must ensure that
        /// the provided type is one that the verifier supports, and that the attestation payload is a valid
        /// instantiation of that type (for example by validating a JSON schema).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The cryptographic fingerprint of the key used to generate the signature, as output by, e.g. `gpg
        /// --list-keys`. This should be the version 4, full 160-bit fingerprint, expressed as a 40 character
        /// hexidecimal string. See https://tools.ietf.org/html/rfc4880#section-12.2 for details. Implementations may
        /// choose to acknowledge "LONG", "SHORT", or other abbreviated key IDs, but only the full fingerprint is
        /// guaranteed to work. In gpg, the full fingerprint can be retrieved from the `fpr` field returned when calling
        /// --list-keys with --with-colons. For example: ``` gpg --with-colons --with-fingerprint --force-v4-certs \
        /// --list-keys attester@example.com tru::1:1513631572:0:3:1:5 pub:......
        /// fpr:::::::::24FF6481B76AC91E66A00AC657A93A81EF3AE6FB: ``` Above, the fingerprint is
        /// `24FF6481B76AC91E66A00AC657A93A81EF3AE6FB`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pgpKeyId")]
        public virtual string PgpKeyId { get; set; }

        /// <summary>Required. The raw content of the signature, as output by GNU Privacy Guard (GPG) or equivalent.
        /// Since this message only supports attached signatures, the payload that was signed must be attached. While
        /// the signature format supported is dependent on the verification implementation, currently only ASCII-armored
        /// (`--armor` to gpg), non-clearsigned (`--sign` rather than `--clearsign` to gpg) are supported. Concretely,
        /// `gpg --sign --armor --output=signature.gpg payload.json` will create the signature content expected in this
        /// field in `signature.gpg` for the `payload.json` attestation payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud
    /// resources. A `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`.
    /// Members can be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a
    /// named list of permissions; each `role` can be an IAM predefined role or a user-created custom role. For some
    /// types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that
    /// allows access to a resource only if the expression evaluates to `true`. A condition can add constraints based on
    /// attributes of the request, the resource, or both. To learn which resources support conditions in their IAM
    /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON
    /// example:** { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [
    /// "user:mike@example.com", "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-
    /// id@appspot.gserviceaccount.com" ] }, { "role": "roles/resourcemanager.organizationViewer", "members": [
    /// "user:eve@example.com" ], "condition": { "title": "expirable access", "description": "Does not grant access
    /// after Sep 2020", "expression": "request.time < timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag":
    /// "BwWWja0YfJA=", "version": 3 } **YAML example:** bindings: - members: - user:mike@example.com -
    /// group:admins@example.com - domain:google.com - serviceAccount:my-project-id@appspot.gserviceaccount.com role:
    /// roles/resourcemanager.organizationAdmin - members: - user:eve@example.com role:
    /// roles/resourcemanager.organizationViewer condition: title: expirable access description: Does not grant access
    /// after Sep 2020 expression: request.time < timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version:
    /// 3 For a description of IAM and its features, see the [IAM
    /// documentation](https://cloud.google.com/iam/docs/).</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines
        /// how and when the `bindings` are applied. Each of the `bindings` must contain at least one member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an
        /// invalid value are rejected. Any operation that affects conditional role bindings must specify version `3`.
        /// This requirement applies to the following operations: * Getting a policy that includes a conditional role
        /// binding * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy *
        /// Removing any role binding, with or without a condition, from a policy that includes conditions
        /// **Important:** If you use IAM Conditions, you must include the `etag` field whenever you call
        /// `setIamPolicy`. If you omit this field, then IAM allows you to overwrite a version `3` policy with a version
        /// `1` policy, and all of the conditions in the version `3` policy are lost. If a policy does not include any
        /// conditions, operations on that policy may specify any valid version or leave the field unset. To learn which
        /// resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

    }    

    /// <summary>Selects a repo using a Google Cloud Platform project ID (e.g., winged-cargo-31) and a repo name within
    /// that project.</summary>
    public class ProjectRepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of the repo. Leave empty for the default repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata for any related URL information.</summary>
    public class RelatedUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label to describe usage of the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Specific URL associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A unique identifier for a Cloud Repo.</summary>
    public class RepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A combination of a project ID and a repo name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectRepoId")]
        public virtual ProjectRepoId ProjectRepoId { get; set; }

        /// <summary>A server-assigned, globally unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An entity that can have metadata. For example, a Docker image.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated, do not use. Use uri instead. The hash of the resource content. For example, the Docker
        /// digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentHash")]
        public virtual Hash ContentHash { get; set; }

        /// <summary>Deprecated, do not use. Use uri instead. The name of the resource. For example, the name of a
        /// Docker image - "Debian".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The unique URI of the resource. For example, `https://gcr.io/project/image@sha256:foo`
        /// for a Docker image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A scan configuration specifies whether Cloud components in a project have a particular type of analysis
    /// being run. For example, it can configure whether vulnerability scanning is being done on Docker images or
    /// not.</summary>
    public class ScanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time this scan config was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. A human-readable description of what the scan configuration does.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Whether the scan is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Output only. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The time this scan config was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to
        /// a few 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Verifiers (e.g. Kritis implementations) MUST verify signatures with respect to the trust anchors
    /// defined in policy (e.g. a Kritis policy). Typically this means that the verifier has been configured with a map
    /// from `public_key_id` to public key material (and any required parameters, e.g. signing algorithm). In
    /// particular, verification implementations MUST NOT treat the signature `public_key_id` as anything more than a
    /// key lookup hint. The `public_key_id` DOES NOT validate or authenticate a public key; it only provides a
    /// mechanism for quickly selecting a public key ALREADY CONFIGURED on the verifier through a trusted channel.
    /// Verification implementations MUST reject signatures in any of the following circumstances: * The `public_key_id`
    /// is not recognized by the verifier. * The public key that `public_key_id` refers to does not verify the signature
    /// with respect to the payload. The `signature` contents SHOULD NOT be "attached" (where the payload is included
    /// with the serialized `signature` bytes). Verifiers MUST ignore any "attached" payload and only verify signatures
    /// with respect to explicitly provided payload (e.g. a `payload` field on the proto message that holds this
    /// Signature, or the canonical serialization of the proto message that holds this signature).</summary>
    public class Signature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier for the public key that verifies this signature. * The `public_key_id` is required.
        /// * The `public_key_id` SHOULD be an RFC3986 conformant URI. * When possible, the `public_key_id` SHOULD be an
        /// immutable reference, such as a cryptographic digest. Examples of valid `public_key_id`s: OpenPGP V4 public
        /// key fingerprint: * "openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA" See
        /// https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr for more details on this scheme. RFC6920
        /// digest-named SubjectPublicKeyInfo (digest of the DER serialization): *
        /// "ni:sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU" *
        /// "nih:sha-256;703f68f42aba2c6de30f488a5ea122fef76324679c9bf89791ba95a1271589a5"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyId")]
        public virtual string PublicKeyId { get; set; }

        /// <summary>The content of the signature, an opaque bytestring. The payload that this signature verifies MUST
        /// be unambiguously provided with the Signature during verification. A wrapper message might provide the
        /// payload explicitly. Alternatively, a message might have a canonical serialization that can always be
        /// unambiguously computed to derive the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string SignatureValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This defines the format used to record keys used in the software supply chain. An in-toto link is
    /// attested using one or more keys defined in the in-toto layout. An example of this is: { "key_id":
    /// "776a00e29f3559e0141b3b096f696abc6cfb0c657ab40f441132b345b0...", "key_type": "rsa", "public_key_value": "-----
    /// BEGIN PUBLIC KEY-----\nMIIBojANBgkqhkiG9w0B...", "key_scheme": "rsassa-pss-sha256" } The format for in-toto's
    /// key definition can be found in section 4.2 of the in-toto specification.</summary>
    public class SigningKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>key_id is an identifier for the signing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>This field contains the corresponding signature scheme. Eg: "rsassa-pss-sha256".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyScheme")]
        public virtual string KeyScheme { get; set; }

        /// <summary>This field identifies the specific signing method. Eg: "rsa", "ed25519", and "ecdsa".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>This field contains the actual public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyValue")]
        public virtual string PublicKeyValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Source describes the location of the source used for the build.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If provided, some of the source code used for the build may be found in these locations, in the
        /// case where the source repository had multiple remotes or submodules. This list will not include the context
        /// specified in the context field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalContexts")]
        public virtual System.Collections.Generic.IList<SourceContext> AdditionalContexts { get; set; }

        /// <summary>If provided, the input binary artifacts for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorageSourceUri")]
        public virtual string ArtifactStorageSourceUri { get; set; }

        /// <summary>If provided, the source code used for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual SourceContext Context { get; set; }

        /// <summary>Hash(es) of the build source, which can be used to verify that the original source integrity was
        /// maintained in the build. The keys to this map are file paths used as build source and the values contain the
        /// hash values for those files. If the build source came in a single package such as a gzipped tarfile
        /// (.tar.gz), the FileHash will be for the single path to that file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, FileHashes> FileHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A SourceContext is a reference to a tree of files. A SourceContext together with a path point to a
    /// unique revision of a single file or directory.</summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A SourceContext referring to a revision in a Google Cloud Source Repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRepo")]
        public virtual CloudRepoSourceContext CloudRepo { get; set; }

        /// <summary>A SourceContext referring to a Gerrit project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerrit")]
        public virtual GerritSourceContext Gerrit { get; set; }

        /// <summary>A SourceContext referring to any third party Git repo (e.g., GitHub).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual GitSourceContext Git { get; set; }

        /// <summary>Labels with user defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or
        /// 'storage.*') are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Version contains structured information about the version of a package.</summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epoch")]
        public virtual System.Nullable<int> Epoch { get; set; }

        /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The iteration of the package build from the above version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Vulnerability provides metadata about a security vulnerability in a Note.</summary>
    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CVSS score for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScore")]
        public virtual System.Nullable<float> CvssScore { get; set; }

        /// <summary>The full description of the CVSSv3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV3")]
        public virtual CVSSv3 CvssV3 { get; set; }

        /// <summary>All information about the package to specifically identify this vulnerability. One entry per
        /// (version range and cpe_uri) the package vulnerability has manifested in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<Detail> Details { get; set; }

        /// <summary>Note provider assigned impact of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The time this information was last changed at the source. This is an upstream timestamp from the
        /// underlying information source - e.g. Ubuntu security tracker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUpdateTime")]
        public virtual object SourceUpdateTime { get; set; }

        /// <summary>Windows details get their own format because the information format and model don't match a normal
        /// detail. Specifically Windows updates are done as patches, thus Windows vulnerabilities really are a missing
        /// package, rather than a package being at an incorrect version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsDetails")]
        public virtual System.Collections.Generic.IList<WindowsDetail> WindowsDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The location of the vulnerability.</summary>
    public class VulnerabilityLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) format. Examples
        /// include distro or storage location for vulnerable jar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>Required. The package being described.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>Required. The version of the package being described.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A summary of how many vulnerability occurrences there are per resource and severity type.</summary>
    public class VulnerabilityOccurrencesSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A listing by resource of the number of fixable and total vulnerabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IList<FixableTotalByDigest> Counts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class WindowsDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CPE URI in [cpe format](https://cpe.mitre.org/specification/) in which the
        /// vulnerability manifests. Examples include distro or storage location for vulnerable jar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The description of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The names of the KBs which have hotfixes to mitigate this vulnerability. Note that there
        /// may be multiple hotfixes (and thus multiple KBs) that mitigate a given vulnerability. Currently any listed
        /// kb's presence is considered a fix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixingKbs")]
        public virtual System.Collections.Generic.IList<KnowledgeBase> FixingKbs { get; set; }

        /// <summary>Required. The name of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}

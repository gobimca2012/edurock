<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/StaticSite.master" AutoEventWireup="true"
    CodeFile="Index.aspx.cs" Inherits="Index" Theme="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <h1>
            What is Crameasy?
        </h1>
        <div>
            Crameasy makes document management and knowledge management simple. With Crameasy
            professionals like you regain control over document chaos and manage and collect
            you organization knowledge at central place. You can create, co-author, and coordinate
            business documents and knowledge – anytime and anywhere.
        </div>
    </div>
    <div class="htu">
        <h1>
            How Do We Help You?
        </h1>
        <div class="grayround fl">
            <h3>
                Using Document Management
            </h3>
            <div>
                Crameasy helps you collaborate to create documents online or in Microsoft Office
                tools. You can quickly organize, store, and locate your documents. You get global
                access to your documents and you can manage document workflow and lifecycles in
                a secure, cloud-based business solution.
            </div>
        </div>
        <div class="grayround fl">
            <h3>
                Using Knowledge Management
            </h3>
            <div>
                Crameasy helps you create,organize,store and locate you organization's knowledge
                in varity of media like image,video,audio,article and question answer.it allow you
                to increase quality of knowledge using multilavel catagorization,security,autority,ratting
                and discussion on individual knowledge. You get global access to your knowledge
                and you can manage knowledge in a secure, cloud-based business solution.
            </div>
        </div>
        <div class="grayround fl">
            <h3>
                Using Micro blogging
            </h3>
            <div>
                Crameasy helps you share idea amonge organization's user using micro blogging.it
                allow user to transfer information in faster,effective and reliable way.
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
    <br />
    <%-- <div class="pricing">
        <ul class="fl grayround " style="height: 430px; margin: 0px 3px; padding: 20px">
            <li>
                <h3>
                    On Demand</h3>
            </li>
            <li class="price">
                <img style="width: 150px; height: 60px;" src="http://www.knowledgetree.com/files/images/pricing_Pro.png"
                    alt=""></li>
            <li><strong>limited</strong> users</li>
            <li><strong>20GB</strong> Storage</li>
            <li><strong>1GB</strong> file size limit</li>
            <li class="trial"><a href="/free-trial">Try for Free</a></li>
            <li title="" class="helpertext" bt-xtitle="Access your Crameasy documents directly from Microsoft Office applications, co-author documents, social activity feeds, view document properties. Free for beta period.">
                Crameasy for Office*</li>
            <li>Web support</li>
            <li class="strikethrough">Role &amp; group security</li>
            <li class="strikethrough">Custom properties</li>
            <li class="strikethrough">Advanced search &amp; report builder</li>
            <li title="" class="helpertext" bt-xtitle="Be alerted when a document reaches a certain age or on a specific date. *Sending limited to users and built-in roles, not groups of users.">
                Limited Document Alerts</li>
            <li class="strikethrough">Workflow</li>
            <li class="strikethrough">Electronic Signatures</li>
            <li class="strikethrough">Custom Domain</li>
        </ul>
        <ul class="fl roundallcorsmall box-shadow" style="height: 450px; margin: 0px 3px;
            padding: 20px;">
            <li>
                <h3>
                    Team</h3>
            </li>
            <li class="price">
                <img style="width: 150px; height: 60px;" src="http://www.knowledgetree.com/files/images/pricing_Team.png"
                    alt=""></li>
            <li><strong>Unlimited</strong> users</li>
            <li><strong>60GB</strong> Storage</li>
            <li><strong>1GB</strong> file size limit</li>
            <li class="trial"><a href="/free-trial">Try for Free</a></li>
            <li title="" class="helpertext" bt-xtitle="Access your KnowledgeTree documents directly from Microsoft Office applications, co-author documents, social activity feeds, view document properties. Free for beta period.">
                KnowledgeTree for Office*</li>
            <li>Web support</li>
            <li title="" class="helpertext" bt-xtitle="Assign users to groups and set content permissions for these groups.">
                Role &amp; group security</li>
            <li title="" style="background-color: rgb(255, 255, 204);" class="helpertext" bt-xtitle="Add your own custom property fields to file metadata. These can be text fields, rich-text fields, dates, and pick lists.">
                Custom properties</li>
            <li title="" class="helpertext" bt-xtitle="Build custom boolean queries that search full-text content, metadata properties, and transactional information. Save searches for later re-use.">
                Advanced search &amp; report builder</li>
            <li title="" style="background-color: rgb(255, 255, 204);" class="helpertext" bt-xtitle="Set aging alerts on documents: alert users or groups of users when a document reaches a certain age, or on a specific date.">
                Document Alerts</li>
            <li class="strikethrough">Workflow</li>
            <li class="strikethrough">Electronic Signatures</li>
            <li class="strikethrough">Custom Domain</li>
        </ul>
        <ul class="fl grayround" style="height: 430px; margin: 0px 3px; padding: 20px">
            <li>
                <h3>
                    Company</h3>
            </li>
            <li class="price">
                <img style="width: 150px; height: 60px;" src="http://www.knowledgetree.com/files/images/pricing_Company.png"
                    alt=""></li>
            <li><strong>Unlimited</strong> users</li>
            <li><strong>150GB</strong> Storage</li>
            <li><strong>2GB</strong> file size limit</li>
            <li class="trial"><a href="/free-trial">Try for Free</a></li>
            <li title="" class="helpertext" bt-xtitle="Access your KnowledgeTree documents directly from Microsoft Office applications, co-author documents, social activity feeds, view document properties. Free for beta period.">
                KnowledgeTree for Office*</li>
            <li>Web support</li>
            <li>Role &amp; group security</li>
            <li>Custom properties</li>
            <li>Advanced search &amp; report builder</li>
            <li>Document Alerts</li>
            <li title="" style="background-color: rgb(255, 255, 204);" class="helpertext" bt-xtitle="Manage approvals and processes by building document routing workflows.">
                Workflow</li>
            <li class="strikethrough">AD/LDAP integration</li>
            <li class="strikethrough">Electronic Signatures</li>
            <li class="strikethrough">Custom Domain</li>
        </ul>
        <ul style="width: 190px; border: 1px solid #D3D3D3; padding: 15px;" class="fr roundallcorsmall">
            <li>
                <h3>
                    Enterprise</h3>
            </li>
            <p>
                Enterprise features for growing companies. Dedicated account manager, phone support
                and <strong>Service Level Agreement</strong>. Unlimited storage, <span title="" style="background-color: rgb(255, 255, 204);"
                    class="helpertext" bt-xtitle="Securely integrate your KnowledgeTree account with your on-premise LDAP or Microsoft Active Directory server.">
                    AD / LDAP integration</span>, <span title="" style="background-color: rgb(255, 255, 204);"
                        class="helpertext" bt-xtitle="Download to your own network a backup of all your data">
                        Offline backups</span>, <span title="" style="background-color: rgb(255, 255, 204);"
                            class="helpertext" bt-xtitle="Require users to provide their user ID and password when carrying out certain auditable actions ">
                            electronic signatures</span>, <span title="" style="background-color: rgb(255, 255, 204);"
                                class="helpertext" bt-xtitle="Use your company domain to access your KnowledgeTree account without reference to knowledgetree.com">
                                custom domain</span> and 5GB file size upload limit</p>
            <li style="float: right;" class="trial"><a rel="lightframe[|width:500px; height:400px; scrolling: no;]"
                href="http://www2.knowledgetree.com/l/2622/2010-06-16/1ZO4X" class="lightbox-processed">
                Contact Us</a></li>
        </ul>
        <ul style="width: 190px; border: 1px solid #D3D3D3; padding: 15px;" class="fr roundallcorsmall">
            <h3>
                On-Site (25+ users)</h3>
            <p>
                Installable, on-premise, document management software for 25 or more users</p>
            <li style="float: right;" class="trial"><a rel="lightframe[|width:500px; height:400px; scrolling: no;]"
                href="http://www2.knowledgetree.com/l/2622/2010-06-15/1Y4VR" class="lightbox-processed">
                Contact Us</a></li>
        </ul>
        <div class="clear">
        </div>
    </div>--%>
    <div class="clear">
        <div style="" class="colum1 " id="dnn_ContentPane">
            <div>
                <h5>
                    Blog</h5>
                <img src="Images/Blog.png" style="float: right;" alt=""><p>
                    Turn your workforce into a perpetual idea machine with Blogs. Blogging internally
                    with CramEasy encourages users to publish their ideas and opinions and get feedback
                    in the form of comments. Blogs act as an effective medium to capture ideas, open
                    dialogue, communicate activities like project updates and interact with employees.
                    CramEasy enables collaborative authoring of blog posts. Blog posts can be enriched
                    by reusing existing images, audio's, videos as well as embedding external content.</p>
                <div class="clear">
                </div>
                <h5>
                    <p>
                        File Repositories</p>
                </h5>
                <img src="Images/file-manager.png" style="float: right; width: 64px; height: 64px;"
                    alt=""><p>
                        Securely manage documents and files across offices/Institutes. CramEasy lets organizations
                        to centrally store and manage documents, spreadsheets, media, or any kind of files
                        securely within spaces/Course/Department. Files uploaded to CramEasy are instantly
                        indexed to make them easily searchable by contained content. Version history of
                        all files added, edited or deleted is maintained ensuring complete safety of all
                        content and adherence to compliance requirements. Access privileges can be easily
                        controlled at the space level or for individual files.</p>
                <div class="clear">
                </div>
                <h5>
                    <p>
                    </p>
                </h5>
                <h5>
                    Event Calendars</h5>
                <p>
                </p>
                <img src="Images/Event.png" style="float: right;" alt=""><p>
                </p>
                <p>
                    Communicate, co-ordinate and maintain schedules across the company using event calendars
                    in CramEasy. Calendars in CramEasy help organizations to communicate time and schedules
                    across teams and keep everyone in perpetual sync. Calendars can generically be used
                    for managing release schedules, HR leave calendars, enterprise-wide meeting planning,
                    project milestone management, etc.</p>
                <p>
                </p>
                <div class="clear">
                </div>
                <h5>
                    <p>
                    </p>
                </h5>
                <h5>
                    <p>
                        <strong></strong>
                    </p>
                </h5>
                <h5>
                    <p>
                        <strong>Course Management</strong></p>
                </h5>
                <p>
                </p>
                <img src="Images/Blog.png" style="float: right;" alt=""><p>
                </p>
                <p>
                </p>
                <p>
                    Administrator of Organization or Institute can create new Course and publish. Provide
                    facility to publish course for specific time period. Individual space for course
                    where user can publish blog, event, image, audio, document, and video and post question
                    .user has dashboard in which user will get update from individual courses. Administrator
                    and User who has right to post examination/quiz can create new examination in individual
                    course, users in course attend examination/quiz using web base Ajax Interface.</p>
                <p>
                    Facility to write about course, ability to add new subject and describe subjects
                    in particular course.</p>
                <p>
                </p>
                <h5>
                    <p>
                    </p>
                </h5>
                <h5>
                    <strong>WYSIWYG Content Editor</strong></h5>
                <p>
                </p>
                <p>
                </p>
                <img src="Images/Documents.png" style="float: right; width: 64px; height: 64px;"
                    alt=""><p>
                    </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                    CramEasy incorporates a powerful editor to edit rich web content within Examination
                    and blogs and works just like your desktop word processor software. Along with powerful
                    WYSIWYG features like visual table creation, keyboard shortcuts and rich content
                    formatting, the editor integrates tightly into CramEasy , allowing visual searching
                    and insertion of links and media from within CramEasy . Keyboard shortcuts, quick
                    access drawers, and a full screen mode makes the user experience highly productive.
                    The editor auto saves all content to the server every minute, so you don't have
                    to worry about loosing any content due to system crashes or power failures.</p>
                <p>
                </p>
                <h5>
                </h5>
                <h5>
                    <strong>Email Notifications</strong></h5>
                <p>
                </p>
                <p>
                </p>
                <img src="Images/Quistion.png" style="float: right;" alt=""><p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                    CramEasy &nbsp;provides an easy to use e-mail subscription feature that lets you
                    subscribe to any content or a space with the click of a button. Anytime any other
                    user updates the content an alert is sent to your email. When you subscribe to a
                    space, all content or spaces under it automatically start sending alerts to you.
                    Clicking the same button again un-subscribes you of the notifications.</p>
                <br>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="colum2" id="dnn_LeftPane">
            <div>
                <h5>
                    Image Galleries</h5>
                <p>
                </p>
                <img style="float: right; width: 64px; height: 64px;" src="Images/imagegallery.png"
                    alt=""><p>
                    </p>
                <p>
                    Present and communicate better with Image Galleries in CramEasy. Store, annotate,
                    catalogue and distribute digital assets like pictures, presentations, stock images,
                    logos and graphics using CramEasy image galleries.</p>
                <p>
                </p>
                <div class="clear">
                </div>
                <h5>
                    <p>
                    </p>
                </h5>
                <h5>
                    Audio Galleries</h5>
                <p>
                </p>
                <img style="float: right; width: 64px; height: 64px;" src="Images/Audio.png" alt=""><p>
                </p>
                <p>
                    Audio libraries within CramEasy enables teams to share audio content such as meeting
                    recordings, training lectures, and other audio assets. MP3 audio files can be directly
                    played from within the CramEasy web browser interfaces making CramEasy the most
                    painless tool for simple audio broadcast and consumption. <strong></strong>
                </p>
                <p>
                </p>
                <div class="clear">
                </div>
                <h5>
                    <p>
                    </p>
                </h5>
                <h5>
                    Video Libraries</h5>
                <p>
                </p>
                <img style="float: right; width: 64px; height: 64px;" src="Images/Video.png" alt=""><p>
                </p>
                <p>
                    Enhance learning by publishing and broadcasting Video. CramEasy provides for a Youtube
                    like video sharing application that lets teams publish videos within spaces/Courses,
                    and watch them directly in the web browser. This opening up newer avenues for effective
                    communication, training and knowledge sharing using rich multimedia.<strong></strong></p>
                <p>
                </p>
                <div class="clear">
                </div>
                <h5>
                </h5>
                <h5>
                    Document &nbsp;Libraries</h5>
                <img style="float: right; width: 64px; height: 64px;" src="Images/Documents.png"
                    alt=""><p>
                        Enhance learning by publishing and broadcasting Video. CramEasy provides for a Youtube
                        like video sharing application that lets teams publish videos within spaces/Courses,
                        and watch them directly in the web browser. This opening up newer avenues for effective
                        communication, training and knowledge sharing using rich multimedia.</p>
                <div class="clear">
                </div>
                <h5>
                </h5>
                <h5>
                    <strong>Status Logs</strong></h5>
                <img style="float: right; width: 64px; height: 64px;" src="Images/Course.png" alt=""><p>
                </p>
                CramEasy allow users to add brief messages or updates to their profiles, that form
                a chronological status log for the user. Status logs provide a broadcast type of
                communication channel to each CramEasy user, updating their peers about day-to-day
                workings &amp; creating transparency towards business activity. Threaded discussions
                on status messages provide for 2 way communication and makes status messages a useful
                tool to interact about day to day activities.<br>
                <br>
                <h5>
                </h5>
                <h5>
                    <strong>People Directory</strong></h5>
                <img style="float: right; width: 64px; height: 64px;" src="Images/Audio.png" alt=""><p>
                </p>
                <p>
                    CramEasy's extensive user management features allow users to find people and expertise
                    using the profile search and the people directory. A user can be a part of multiple
                    groups and roles can be assigned to users and groups.</p>
                <h5>
                </h5>
                <h5>
                    <strong>Webdav Access </strong>
                </h5>
                <img style="float: right; width: 64px; height: 64px;" src="Images/48Knowledge.png"
                    alt=""><p>
                    </p>
                <p>
                </p>
                <p>
                    CramEasy &nbsp;provides a standards compliant Web-DAV protocol based access to all
                    content within CramEasy . CramEasy &nbsp;Web-DAV can be directly accessed with Mac
                    OSX and Linux computers and using a standards compliant Web-DAV client (e.g. Web
                    drive) on Windows.</p>
                <p>
                </p>
                <br>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="colum3" id="dnn_RightPane">
            <div>
                <h5>
                    Discussion Boards</h5>
                <p>
                </p>
                <img src="Images/QA.png" style="float: right; width: 64px; height: 64px;" alt=""><p>
                </p>
                <p>
                    Discussion boards in CramEasy enable users to quick start a '1 to many' conversation
                    and get quicker feedback and participation. Using CramEasy discussions, employees
                    can ask questions, find answers, provide opinions or brainstorm ideas freely. This
                    potentially replaces email as the tool of choice for 1 to many and many to many
                    communication as all discussions are threaded, searchable and organized centrally
                    within spaces/Course. Discussions provide a pan-organizational platform for emergent,
                    open yet vital communication.</p>
                <p>
                </p>
                <h5>
                    Online Examination</h5>
                <p>
                </p>
                <img src="Images/exam.png" style="float: right; width: 64px; height: 64px;" alt=""><p>
                </p>
                <p>
                    Discussion boards in CramEasy enable users to quick start a '1 to many' conversation
                    and get quicker feedback and participation. Using CramEasy discussions, employees
                    can ask questions, find answers, provide opinions or brainstorm ideas freely. This
                    potentially replaces email as the tool of choice for 1 to many and many to many
                    communication as all discussions are threaded, searchable and organized centrally
                    within spaces/Course. Discussions provide a pan-organizational platform for emergent,
                    open yet vital communication.</p>
                <p>
                </p>
                <h5>
                    <strong>User Management</strong></h5>
                <p>
                </p>
                <img src="Images/Catagory%20Management.png" style="float: right;" alt=""><p>
                </p>
                <p>
                    Role Based power full and secure User Management. Administrator can create new role,can
                    create new user &nbsp;and give access of different feature to users and roles, give
                    permission for edit delete, add, view&nbsp; to users and roles. System gives choice
                    for self registration and manual registration.Provide Self registration for Free
                    Course/Space, Provide Online Payment facility &nbsp;for paid course/space.</p>
                <p>
                </p>
                <h5>
                </h5>
                <h5>
                    <strong>Crowd Rating &amp; Voting</strong></h5>
                <p>
                </p>
                <img src="Images/DataSharing.png" style="float: right;" alt=""><p>
                </p>
                <p>
                </p>
                <p>
                    Just like contextual discussions, all content in CramEasy can be rated as liked
                    or disliked by CramEasy users with access to the content. More liked content automatically
                    get a higher rating and 'bubble up' in the activity streams. Ratings enable a democratic
                    model of information filtering and knowledge creation. It also serves as a useful
                    tool to gather feedback on ideas and aids decision making.</p>
                <p>
                </p>
                <h5>
                </h5>
                <h5>
                    <strong>People Profiles &amp; Infocards </strong>
                </h5>
                <p>
                </p>
                <img src="Images/Catagory%20Management.png" style="float: right;" alt=""><p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                    Every CramEasy user is provided with a profile page which along with the users basic
                    contact / business information, also dynamically aggregates the user's activity
                    and contributed content in a consolidated dashboard. The user profile provides insight
                    to the user perspective and helps people to identify peers with required skills
                    or common interests. A live mini profile also known as an 'Infocard' provides quick
                    essential information about users and can be brought up by clicking on a users name
                    anywhere within CramEasy.</p>
                <p>
                </p>
                <br>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>

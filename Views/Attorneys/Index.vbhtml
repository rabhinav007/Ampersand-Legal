@Code ViewBag.Title = "Our Team" End Code

<div class="container py-5" ; style="background-color: #f8f8f8;">
    <h1 style="text-align: center; margin-bottom: 30px; color: #a68a64; font-weight: 700; "> Meet our Legal Experts</h1>

    <style>
        body {
            background-color: #f8f8f8 /*#f4f1ea*/ !important;
        }

        .section-heading {
            background-color: white;
            border-left: 5px solid #007bff;
            padding: 10px 20px;
            margin-top: 40px;
            margin-bottom: 20px;
            font-weight: bold;
            font-size: 1.5rem;
        }

        .team-card {
            display: flex;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin-bottom: 20px;
            align-items: flex-start;
        }

            .team-card img {
                width: 300px;
                height: 200px;
                object-fit: cover;
                border-radius: 5px;
                margin-right: 20px;
            }

            .team-card h4 {
                margin-bottom: 5px;
            }

            .team-card h6 {
                margin-bottom: 10px;
                text-transform: capitalize;
            }

        .italic-des {
            font-style: italic;
        }

        .description {
            overflow: hidden;
            display: -webkit-box;
            -webkit-line-clamp: 2;
            -webkit-box-orient: vertical;
            transition: all 0.3s ease;
        }

            .description.expanded {
                -webkit-line-clamp: unset;
            }

        .read-more {
            color: #a68a64;
            cursor: pointer;
            display: inline-block;
            margin-top: 5px;
        }

        .attorney-card {
            position: relative;
            overflow: hidden;
        }

        .linkedin-icon {
            position: absolute;
            bottom: 16px;
            right: 16px;
            display: inline-block;
        }

            .linkedin-icon img {
                width: 28px;
                height: 28px;
                object-fit: contain;
            }
    </style>

    <!-- Founding Partners -->
    <div style="color: #a68a64;" class="section-heading">Partners</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Vipul Pankaj Sanghi">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Vipul Pankaj Sanghi</h4>
            <h6 class="text-muted italic-des">Co-Founder & Managing Partner</h6>
            <p class="description">Vipul is an experienced commercial dispute resolution lawyer withemphasis on matters pertaining to the original side jurisdiction. He hasserved as a Counsel for the Govt. of National Capital Territory of Delhi(GNCTD) before the High Court of Delhi and advised bodies like theDelhi Police; Municipal Corporation of Delhi; PWD; District Magistrates;SDMs et cetera.He is an alumnus of the Campus Law Centre, Faculty of Law, Universityof Delhi (LL.B.; 2010) with a Master of Laws from the Indian LawInstitute, New Delhi (2011). He was enrolled with the Bar Council of Delhiin 2010.</p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>

        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Ananya Kar Sanghi">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Ananya Kar Sanghi</h4>
            <h6 class="text-muted italic-des">Co-Founder & Partner</h6>
            <p class="description">
                Ananya is a practicing lawyer with over 15 years of experience in dispute resolution and arbitrations with emphasis on women and child centric laws. She appears regularly before the Supreme Court; High Courts; District Courts and various other fora including Consumer Commissions; CAT;  DRT; FC et cetera, particularly in Delhi NCR and also at Bengaluru, Chennai, Kolkata and Uttarakhand.
                She is an alumnus of the Campus Law Centre, Faculty of Law, University of Delhi (LL.B.; 2008) with PG Diplomas in Alternate Dispute Resolution from the Indian Law Institute, New Delhi (2007) and in Rural Management from Xavier’s Institute of Social Service, Ranchi (2013). She was enrolled with the Bar Council of Delhi in 2008.
                Ananya is also involved in providing services as an advisor to organisations  in relation to safeguarding policies at workplaces, particularly in light of the Sexual Harassment of Women at Workplace (Prevention, Prohibition and Redressal) Act, 2013 (POSH Act). Additionally, she also provides legal support by way of sessions/ consultations/ opinions et cetera in matters involving POSH Act. She is also an active resource person to the National Commission for Protection of Child Rights (NCPCR), particularly in the arena of capacity building/ sensitisation/ legal workshops on various laws relating to children involving stakeholders such as SJPUs; SPPs; Sessions Judges; and Magistrates.
                By virtue of being a legal practitioner, Ananya seeks to bridge the hurdles faced towards seeking timely and essential guidance, queries as well as representation in the legal arena.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <!--<div class="team-card">-->
    @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Shivanshu Kumar">*@
    <!--<div>
            <h4>Shivanshu Kumar</h4>
            <h6 class="text-muted italic-des">Co-Founder & Partner</h6>
            <p class="description">
                Shivanshu Kumar represents and advises corporates; start-ups; public sector undertakings; and individuals in relation to litigation and associated matters. He has an in-depth experience in civil; commercial;intellectual property disputes; and arbitration matters. He advises andrepresents clients in numerous proceedings before various courts and fora and appears regularly before the Supreme Court; High Courts;Arbitral Tribunals; Consumer Commissions, DRTs; and AppellateTribunal, across India. He is also an expert in Insolvency law, havingadvised numerous IPEs; Insolvency Professionals; and Public SectorBanks.
                Shivanshu is an alumnus of the Chanakya National Law University (LL.B.
                Hons.; 2012) and is a Master of Laws from Faculty of Law, University of Delhi (2022). He was enrolled with the Bar Council of Delhi in 2012 and has been in active practice since.
                His clients include the Oriental Insurance Co. Ltd.; Cashgrail PrivateLimited (Zupee); Ansal Urban Condominium Pvt. Ltd.; Jaipuria BuildconPvt. Ltd.; Zomato Limited; Kia Motors (India); Ramacivil IndiaConstruction Pvt. Ltd.; GHV Advanced Pvt. Ltd. (Pristyn Care);Wheelseye Technology India Pvt. Ltd.; Bright Lifecare Pvt. Ltd. (Healthkart); Head Digital Works Pvt. Ltd. (A23 gaming); MWYN TechPvt. Ltd. (Money Tap); Roppen Transportation Services Pvt. Ltd. (Rapido).
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>-->
    <!-- Associates -->
    <div style="color: #a68a64;" class="section-heading">Associates</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Prateek Vaish">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Prateek Vaish</h4>
            <h6 class="text-muted italic-des">Managing Associate</h6>
            <p class="description">
                Prateek has worked as an astute professional in the banking field having more than a decade of experience in banking and over 6 years of experience in litigation. His core competency areas in the field of litigation include consumer disputes; service matters; insurance; as well as commercial litigation. He has represented clients before Tribunals like CAT, DCDRC, NCDRC, ATFP etc.; District Courts;  High Court of Delhi and the Supreme Court of India.
                Prateek is an alumnus of the Campus Law Centre, Faculty of Law, University of Delhi and is currently pursuing his Masters from J.N.U. in Corporate Law.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/prateek-vaish-7b952830/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>



    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Anshika Verma">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Anshika Verma</h4>
            <h6 class="text-muted italic-des">Senior Associate</h6>
            <p class="description">
                Anshika Verma is a practising lawyer with over 9 years of experience in  diversified matters, including, inter alia, Service matters; Consumer disputes; civil matters; criminal matters; and I.B.C. matters. She is having regular appearance before District Courts; High Court of Delhi; NCLT; NCLAT; NCDRC and various other Tribunals in Delhi.
                She is an alumnus of National Law University, Odisha having specialization in Corporate Law and Post Graduation from Shri Ram Swaroop Memorial University, Lucknow.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Manpreet Chadha">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Neha Arya</h4>
            <h6 class="text-muted italic-des">Associate</h6>
            <p class="description">
                Neha Arya is a recent law graduate from the University of Delhi, with a strong interest in litigation and a dedicated approach to legal practice. She assists in handling Civil, Commercial, and Constitutional matters before the Delhi High Court and other forums, assisting in drafting, case analysis, and court proceedings. Through her  internships and associate roles, she continues to build a practical understanding of procedural and substantive law. Her interests include Commercial Law, Arbitration Law, Constitutional Law, and Intellectual Property Laws.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/neha-arya-569a93279/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>
    <!-- Consultants -->
    <div style="color: #a68a64;" class="section-heading">Consultants</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Pankaj Sanghi">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Pankaj Sanghi</h4>
            <h6 class="text-muted italic-des">Senior Consultant</h6>
            <p class="description">
                Mr. Sanghi is the erstwhile Director of Prosecution, Govt. of NCT of Delhi. He has had a long standing at the bar and has had a dynamic career spanning more than 4 decades. He is a stalwart when it comes to the tenets of criminal law and has represented the State in many high profile cases during his tenure as prosecutor.
                Mr. Sanghi joined the Bar in 1982 and has since been dedicated to the profession. He now actively advises the firm on crucial matters pertaining to white collar crimes; economic offences; matters of the Enforcement Directorate and various others.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Indira Murthy">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Rishu Agarwal</h4>
            <h6 class="text-muted italic-des"> Consultant</h6>
            <p class="description">
                Rishu is a dynamic and accomplished legal professional, registered with the Bar Council of Delhi with over nine years of extensive experience in litigation, arbitration, and legal advisory. She has built a distinguished career representing clients across India in complex civil, commercial, service, and matrimonial matters, including high-stakes arbitrations and immigration matters.
                She holds post-graduate diplomas in Alternate Dispute Resolution and Corporate Laws from the Indian Law Institute, along with a Bachelor of Laws (LL.B.) from Lloyd Law College and a Bachelor of Commerce from the University of Mumbai.
                Recognized for her courtroom confidence, meticulous drafting, and client-focused advocacy, Rishu brings a thoughtful, persuasive, and solution-oriented approach to every case. She continues to be a trusted legal counsel for corporate entities, start-ups, and individuals seeking effective legal solutions with professionalism and integrity.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Mohit Daraad">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Mohit Daraad</h4>
            <h6 class="text-muted italic-des">Consultant</h6>
            <p class="description">
                Mohit is an Advocate-on-record with the Supreme Court of India. His areas of expertise include Employment and Labor issues;  Education; and Service Law. He has a rich experience of over a decade, regularly appearing before the Supreme Court of India; various High Courts;  NCLT; NCLAT; CAT; NCDRC; DRT; MACT; DERC; ITAT; and District Courts.
                Mohit is an alumnus of the Campus Law Center, Faculty of Law, University of Delhi. He offers his services as an empanelled lawyer to Central Board of Secondary Education (CBSE); Axis Bank; Bank of Maharashtra; State Bank of India; Union Bank of India et cetera.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Joseph E. Anthony">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>Joseph E. Anthony</h4>
            <h6 class="text-muted italic-des">Consultant</h6>
            <p class="description">
                Fr. Joseph is a consultant who is currently the Secretary of the Delhi Catholic Archdiocese and also the Chief Coordinator at the Public Relation Office of the Conference of Catholic Bishops of India.
                He joined the Bar in 2012 and has over the period of years gained vast experience in managing myriad areas of the civil society groups, whether within or without the aegis of the Delhi Catholic Archdiocese, which is the parent organisation of all the Catholic bodies in India.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

    <!-- Advisors -->
    <div style="color: #a68a64;" class="section-heading">Advisors</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="J.B. Oli">*@
        <div class="attorney-card position-relative border rounded p-4 h-100" style=overflow: hidden;>
            <h4>J.B. Oli</h4>
            <h6 class="text-muted italic-des">Civil Society Advisor</h6>
            <p class="description">
                Mr. Oli is a civil society development advisor with a vast experience of over 24 years, expositing in the field of strategic leadership in programme development and management; monitoring and evaluation and resource mobilisation, focusing on children; adolescents; and young persons. His work spans in the fields of education; life skills; child protection; mental health; policy advocacy and alliance building.
                Mr. Oli has worked in government and non-government organisations functioning in diverse roles and responsibilities at senior levels. He holds a Master of Arts in Political Science with a focus on International Relations and has undergone number of trainings in leadership; programme management; and impact evaluation. He is deeply committed to improving the lives of marginalised populations and has a strong track record in policy advocacy; organisational development; and capacity building.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
            <a href="https://www.linkedin.com/in/vipulpankajsanghi/" target="_blank" class="linkedin-icon">
                <img src="~/Content/Images/linkedin.png" alt="LinkedIn" />
            </a>
        </div>
    </div>

</div>
<script>
    function toggleDescription(el) {
        const p = el.previousElementSibling;
        p.classList.toggle("expanded");
        el.innerText = p.classList.contains("expanded") ? "Read less" : "Read more";
    }
</script>

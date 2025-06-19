@Code ViewBag.Title = "Our Team" End Code

<div class="container py-5">
    <h2 class="text-center mb-5" style="color: #2c2c2c">Meet our Legal Experts</h2>

    <style>
        .section-heading {
            background-color:white; /*#2c2c2c;*/ /*#a68a64*/
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
            color: /*#007bff*/ #a68a64;
            cursor: pointer;
            display: inline-block;
            margin-top: 5px;
        }

    </style>

    <!-- Founding Partners -->
    <div style="color: #a68a64 "class="section-heading">Founding Partners</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Vipul Pankaj Sanghi">*@
        <div>
            <h4>Vipul Pankaj Sanghi</h4>
            <h6 class="text-muted">Managing & Founding Partner</h6>
            <p class="description">Vipul is an experienced commercial dispute resolution lawyer withemphasis on matters pertaining to the original side jurisdiction. He hasserved as a Counsel for the Govt. of National Capital Territory of Delhi(GNCTD) before the High Court of Delhi and advised bodies like theDelhi Police; Municipal Corporation of Delhi; PWD; District Magistrates;SDMs et cetera.He is an alumnus of the Campus Law Centre, Faculty of Law, Universityof Delhi (LL.B.; 2010) with a Master of Laws from the Indian LawInstitute, New Delhi (2011). He was enrolled with the Bar Council of Delhiin 2010.</p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Ananya Kar Sanghi">*@
        <div>
            <h4>Ananya Kar Sanghi</h4>
            <h6 class="text-muted">Founding Partner</h6>
            <p class="description">
                Ananya is a practicing lawyer with over 15 years of experience in dispute resolution and arbitrations with emphasis on women and child centric laws. She appears regularly before the Supreme Court; High Courts; District Courts and various other fora including Consumer Commissions; CAT;  DRT; FC et cetera, particularly in Delhi NCR and also at Bengaluru, Chennai, Kolkata and Uttarakhand.
                She is an alumnus of the Campus Law Centre, Faculty of Law, University of Delhi (LL.B.; 2008) with PG Diplomas in Alternate Dispute Resolution from the Indian Law Institute, New Delhi (2007) and in Rural Management from Xavier’s Institute of Social Service, Ranchi (2013). She was enrolled with the Bar Council of Delhi in 2008.
                Ananya is also involved in providing services as an advisor to organisations  in relation to safeguarding policies at workplaces, particularly in light of the Sexual Harassment of Women at Workplace (Prevention, Prohibition and Redressal) Act, 2013 (POSH Act). Additionally, she also provides legal support by way of sessions/ consultations/ opinions et cetera in matters involving POSH Act. She is also an active resource person to the National Commission for Protection of Child Rights (NCPCR), particularly in the arena of capacity building/ sensitisation/ legal workshops on various laws relating to children involving stakeholders such as SJPUs; SPPs; Sessions Judges; and Magistrates.
                By virtue of being a legal practitioner, Ananya seeks to bridge the hurdles faced towards seeking timely and essential guidance, queries as well as representation in the legal arena.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Shivanshu Kumar">*@
        <div>
            <h4>Shivanshu Kumar</h4>
            <h6 class="text-muted">Founding Partner</h6>
            <p class="description">
                Shivanshu Kumar represents and advises corporates; start-ups; public sector undertakings; and individuals in relation to litigation and associated matters. He has an in-depth experience in civil; commercial;intellectual property disputes; and arbitration matters. He advises andrepresents clients in numerous proceedings before various courts and fora and appears regularly before the Supreme Court; High Courts;Arbitral Tribunals; Consumer Commissions, DRTs; and AppellateTribunal, across India. He is also an expert in Insolvency law, havingadvised numerous IPEs; Insolvency Professionals; and Public SectorBanks.
                Shivanshu is an alumnus of the Chanakya National Law University (LL.B.
                Hons.; 2012) and is a Master of Laws from Faculty of Law, University of Delhi (2022). He was enrolled with the Bar Council of Delhi in 2012 and has been in active practice since.
                His clients include the Oriental Insurance Co. Ltd.; Cashgrail PrivateLimited (Zupee); Ansal Urban Condominium Pvt. Ltd.; Jaipuria BuildconPvt. Ltd.; Zomato Limited; Kia Motors (India); Ramacivil IndiaConstruction Pvt. Ltd.; GHV Advanced Pvt. Ltd. (Pristyn Care);Wheelseye Technology India Pvt. Ltd.; Bright Lifecare Pvt. Ltd. (Healthkart); Head Digital Works Pvt. Ltd. (A23 gaming); MWYN TechPvt. Ltd. (Money Tap); Roppen Transportation Services Pvt. Ltd. (Rapido).
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <!-- Associates -->
    <div style="color: #a68a64" class="section-heading">Associates</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Prateek Vaish">*@
        <div>
            <h4>Prateek Vaish</h4>
            <h6 class="text-muted">Managing Associate</h6>
            <p class="description">
                Prateek has worked as an astute professional in the banking field having more than a decade of experience in banking and over 6 years of experience in litigation. His core competency areas in the field of litigation include consumer disputes; service matters; insurance; as well as commercial litigation. He has represented clients before Tribunals like CAT, DCDRC, NCDRC, ATFP etc.; District Courts;  High Court of Delhi and the Supreme Court of India.
                Prateek is an alumnus of the Campus Law Centre, Faculty of Law, University of Delhi and is currently pursuing his Masters from J.N.U. in Corporate Law.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Manpreet Chadha">*@
        <div>
            <h4>Manpreet Chadha</h4>
            <h6 class="text-muted">Principal Associate</h6>
            <p class="description">
                Manpreet is a transactional lawyer with over 11 years of experience, consulting primarily in general corporate areas of commercial and regulatory matters as well as arbitrations in a variety of sectors, including Fin-Tech; Ed-tech; Airports; Railways; et cetera and consults on setting up and day-to-day business operations in India and related compliances and laws. Her stellar references include companies like TBWA\ Media Arts Lab; CME India; Power Finance Corporation Ltd.; Rural Electrification Corp.
                Ltd. & India Infrastructure Finance Co. Ltd.; HGC International; ST Telemedia Global Data Centres; Shanghai Pudong Development Bank and the Indian Railways.
                Manpreet is a alumini of Rajiv Gandhi National University of Law, Punjab.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Anshika Verma">*@
        <div>
            <h4>Anshika Verma</h4>
            <h6 class="text-muted">Senior Associate</h6>
            <p class="description">
                Anshika Verma is a practising lawyer with over 9 years of experience in  diversified matters, including, inter alia, Service matters; Consumer disputes; civil matters; criminal matters; and I.B.C. matters. She is having regular appearance before District Courts; High Court of Delhi; NCLT; NCLAT; NCDRC and various other Tribunals in Delhi.
                She is an alumnus of National Law University, Odisha having specialization in Corporate Law and Post Graduation from Shri Ram Swaroop Memorial University, Lucknow.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <!-- Consultants -->
    <div style="color: #a68a64" class="section-heading">Consultants</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Pankaj Sanghi">*@
        <div>
            <h4>Pankaj Sanghi</h4>
            <h6 class="text-muted">Senior Consultant</h6>
            <p class="description">
                Mr. Sanghi is the erstwhile Director of Prosecution, Govt. of NCT of Delhi. He has had a long standing at the bar and has had a dynamic career spanning more than 4 decades. He is a stalwart when it comes to the tenets of criminal law and has represented the State in many high profile cases during his tenure as prosecutor.
                Mr. Sanghi joined the Bar in 1982 and has since been dedicated to the profession. He now actively advises the firm on crucial matters pertaining to white collar crimes; economic offences; matters of the Enforcement Directorate and various others.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Indira Murthy">*@
        <div>
            <h4>Indira Murthy</h4>
            <h6 class="text-muted">Senior Consultant</h6>
            <p class="description">
                Mrs. Murthy is a senior resource consultant on policy matters. She retired as a Joint Secretary with over 34 years of distinguished service in the Government of India and has  experience in over 17 Departments of various Ministries, including Commerce; External Affairs; Industry; Finance; Defence; Personnel and Training; Cabinet Secretariat; Earth Sciences; Social Justice and Empowerment. She has played a pivotal role in policy making and implementation of the same.
                 Her expertise thus extends to a diverse area of policy making and implementation, 	like 	negotiating 	international 	trade 	and implementing trade promotion policies to handling policy and administrative matters of various councils and authorities. She has played key roles in negotiating, formulating and implementing India’s policies vis-à-vis the SAARC Nations; Iran; Pakistan; Bhutan; Sri Lanka; Maldives; Afghanistan; Nepal; Bangladesh; and SAFTA (South Asian Free Trade Area).
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Mohit Daraad">*@
        <div>
            <h4>Mohit Daraad</h4>
            <h6 class="text-muted">Consultant</h6>
            <p class="description">
                Mohit is an Advocate-on-record with the Supreme Court of India. His areas of expertise include Employment and Labor issues;  Education; and Service Law. He has a rich experience of over a decade, regularly appearing before the Supreme Court of India; various High Courts;  NCLT; NCLAT; CAT; NCDRC; DRT; MACT; DERC; ITAT; and District Courts.
                Mohit is an alumnus of the Campus Law Center, Faculty of Law, University of Delhi. He offers his services as an empanelled lawyer to Central Board of Secondary Education (CBSE); Axis Bank; Bank of Maharashtra; State Bank of India; Union Bank of India et cetera.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="Joseph E. Anthony">*@
        <div>
            <h4>Joseph E. Anthony</h4>
            <h6 class="text-muted">Consultant</h6>
            <p class="description">
                Fr. Joseph is a consultant who is currently the Secretary of the Delhi Catholic Archdiocese and also the Chief Coordinator at the Public Relation Office of the Conference of Catholic Bishops of India.
                He joined the Bar in 2012 and has over the period of years gained vast experience in managing myriad areas of the civil society groups, whether within or without the aegis of the Delhi Catholic Archdiocese, which is the parent organisation of all the Catholic bodies in India.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
        </div>
    </div>

    <!-- Advisors -->
    <div style="color: #a68a64" class="section-heading">Advisors</div>

    <div class="team-card">
        @*<img src="@Url.Content("~/Content/images/1.jpg")" alt="J.B. Oli">*@
        <div>
            <h4>J.B. Oli</h4>
            <h6 class="text-muted">Civil Society Advisor</h6>
            <p class="description">
                Mr. Oli is a civil society development advisor with a vast experience of over 24 years, expositing in the field of strategic leadership in programme development and management; monitoring and evaluation and resource mobilisation, focusing on children; adolescents; and young persons. His work spans in the fields of education; life skills; child protection; mental health; policy advocacy and alliance building.
                Mr. Oli has worked in government and non-government organisations functioning in diverse roles and responsibilities at senior levels. He holds a Master of Arts in Political Science with a focus on International Relations and has undergone number of trainings in leadership; programme management; and impact evaluation. He is deeply committed to improving the lives of marginalised populations and has a strong track record in policy advocacy; organisational development; and capacity building.
            </p>
            <span class="read-more" onclick="toggleDescription(this)">Read more</span>
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

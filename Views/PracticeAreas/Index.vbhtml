@Code ViewData("Title") = "Expertise" End Code

<div class="container py-5" style="max-width: 1140px; background-color: #f8f8f8;">
    <h1 style="text-align: center; margin-bottom: 30px;color: #a68a64; font-weight: 700;">Expertise</h1>
    <p class="lead text-center mb-5" style="color: #444;">
        Ampersand Legal represents clients across a wide spectrum of legal services—domestic and international—backed by decades of trusted practice and strategic collaboration.
    </p>

    <style>
        body {
            background-color: #f8f8f8 !important;
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

        .practice-card {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

            .practice-card:hover {
                transform: scale(1.35);
                box-shadow: 0 4px 16px #a68a64;
                z-index: 1;
                position: relative;
            }
    </style>

    <div style="color: #a68a64 " class="section-heading"> Practice Areas</div>

    <div class="row gy-4 mb-2">
        <div class="col-md-6">
            <section id="civil-law" class="practice-details">
                <div class="border rounded p-4 h-100 hover-card">
                    <h4 style="color: #a68a64;"> Civil Law</h4>
                    <ul class="mb-0">
                        <li> Dispute Resolution including ADR (Pan India)</li>
                        <li> Corporate and Commercial Litigation (including IPR)</li>
                        <li> Insolvency and Bankruptcy</li>
                        <li class="more d-none"> Succession and Testamentary Laws</li>
                        <li class="more d-none"> Will Disputes and Wealth Management</li>
                        <li class="more d-none"> Consumer Disputes including Medical Negligence</li>
                        <li class="more d-none"> Service Laws</li>
                        <li class="more d-none"> POSH Litigation</li>
                        <li class="more d-none"> Municipal Laws and Compliances</li>
                        <li class="more d-none"> Matrimonial Disputes</li>
                    </ul>
                    <a href="javascript:void(0);" class="read-more-link mt-2 d-inline-block" style="color: #a68a64; font-weight: 500;" onclick="toggleMore(this)"> Read more</a>
                </div>
            </section>
        </div>

        <div class="col-md-6">
            <section id="corporate-law" class="practice-details">
                <div class="border rounded p-4 h-100 hover-card">
                    <h4 style="color: #a68a64;"> Corporate</h4>
                    <ul class="mb-0">
                        <li> Corporate Advisory, Governance & Compliances</li>
                        <li> Contract Drafting and Vetting</li>
                        <li> Policy Framework</li>
                        <li class="more d-none"> Employee / Workplace Disputes</li>
                        <li class="more d-none"> POSH Trainings, Sessions, and Sensitisation</li>
                        <li class="more d-none"> Data and Privacy Law</li>
                        <li class="more d-none"> Intellectual Property</li>
                        <li class="more d-none"> Corporate Social Responsibility (CSR)</li>
                        <li class="more d-none"> Real Estate Practice (Title Due Diligence and Advisory)</li>
                    </ul>
                    <a href="javascript:void(0);" class="read-more-link mt-2 d-inline-block" style="color: #a68a64; font-weight: 500;" onclick="toggleMore(this)"> Read more</a>
                </div>
            </section>
        </div>
    </div>

    <div class="row gy-4 mb-0">
        <div class="col-md-6">
            <section id="criminal-law" class="practice-details">
                <div class="border rounded p-4 h-100 hover-card">
                    <h4 style="color: #a68a64;"> Criminal Law</h4>
                    <ul class="mb-0">
                        <li> Criminal Litigation (Pan India)</li>
                        <li> White Collar Crimes</li>
                        <li> Laws Relating to Women and Children</li>
                        <li class="more d-none"> Law Relating to Negotiable Instruments</li>
                        <li class="more d-none"> Laws Relating to Prevention of Corruption</li>
                        <li class="more d-none"> Cyber Crimes</li>
                        <li class="more d-none"> Laws Relating to Food Adulteration</li>
                    </ul>
                    <a href="javascript:void(0);" class="read-more-link mt-2 d-inline-block" style="color: #a68a64; font-weight: 500;" onclick="toggleMore(this)"> Read more</a>
                </div>
            </section>
        </div>

        <div class="col-md-6">
            <section id="cross-border" class="practice-details">
                <div class="border rounded p-4 h-100 hover-card">
                    <h4 style="color: #a68a64;"> Cross-border Advisory</h4>
                    <ul class="mb-0">
                        <li> Advisory for NRIs (Business Establishment, Succession, Wealth Management)</li>
                        <li> Joint Ventures</li>
                        <li class="more d-none">  Dispute Resolutions</li>
                        <li class="more d-none"> Company Incorporation, Licences, and Compliances</li>
                        <li class="more d-none"> Drafting and Vetting of Contracts for International Trade</li>
                        <li class="more d-none"> Citizenship and Immigration</li>
                        <li class="more d-none"> Due Diligence</li>
                        <li class="more d-none"> FEMA Compliances</li>
                    </ul>
                    <a href="javascript:void(0);" class="read-more-link mt-2 d-inline-block" style="color: #a68a64; font-weight: 500;" onclick="toggleMore(this)"> Read more</a>
                </div>
            </section>
        </div>
    </div>
</div>

<div class="container py-5" style="max-width: 1140px;">
    <div style="color: #a68a64;" class="section-heading">Sectors</div>
    <div class="row gy-4 mb-5">
        <div class="col-md-6">
            <div class="border rounded p-4 h-100 hover-card">
                @*<h4 style="color: #a68a64;">Industry Sectors We Serve</h4>*@
                <ul class="mb-0">
                    <li>E-commerce & Retail</li>
                    <li>Energy</li>
                    <li>Insurance</li>
                    <li class="more d-none">Pharmaceutical, Healthcare & Life Sciences</li>
                    <li class="more d-none">Real Estate</li>
                    <li class="more d-none">Technology, Media & Telecommunications</li>
                </ul>
                <a href="javascript:void(0);" class="read-more-link mt-2 d-inline-block" style="color: #a68a64; font-weight: 500;" onclick="toggleMore(this)">Read more</a>
            </div>
        </div>
    </div>
</div>




@*<div class="container py-5" style="max-width: 1140px;">
    <div style="color: #a68a64 " class="section-heading"> Our Clients</div>
    <p style="color: #444;">
        The firm’s clientele includes banks, financial institutions, hospitality & F&B companies, e-commerce businesses, healthcare organizations, technology firms, media and entertainment companies, logistics providers, agribusinesses, government undertakings, and PSUs.
    </p>
    <p style="color: #444;">
        For international matters, Ampersand Legal has partnered with an Indo-French legal advisory firm to support cross-border sourcing, regulatory compliance, and global partnerships between India and Europe.
    </p>
</div>*@

<script>
    function toggleMore(link) {
        const list = link.previousElementSibling;
        const hiddenItems = list.querySelectorAll('.more');
        const isExpanded = hiddenItems[0].classList.contains('d-list-item');
        hiddenItems.forEach(item => {
            item.classList.toggle('d-none');
            item.classList.toggle('d-list-item');
        });
        link.textContent = isExpanded ? "Read more" : "Show less";
    }

    document.addEventListener("DOMContentLoaded", function () {
        const hash = window.location.hash;
        if (hash) {
            const target = document.querySelector(hash);
            if (target) {
                const moreItems = target.querySelectorAll(".more");
                moreItems.forEach(item => {
                    item.classList.remove("d-none");
                    item.classList.add("d-list-item");
                });
                const link = target.querySelector(".read-more-link");
                if (link) link.textContent = "Show less";

                const yOffset = -90;
                const y = target.getBoundingClientRect().top + window.pageYOffset + yOffset;
                window.scrollTo({ top: y, behavior: 'smooth' });
            }
        }
    });
</script>
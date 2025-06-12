@Code
    ViewData("Title") = "Home"
End Code

<!-- Hero Section - Muted Color -->
<div style="background-color: #2d2d2d; color: white; padding: 80px 0; text-align: center;">
    <h1 style="font-size: 48px;">Welcome to Ampersand Legal</h1>
    <h4 style="margin-top: 10px;">Contracts to Courtrooms. Covered.</h4>
    <p style="font-size: 16px;">ADVOCATES SINCE 1970</p>
    <a href="@Url.Action("Index", "Contact")" class="btn btn-light" style="margin-top: 20px; padding: 10px 25px;">
        Schedule a Consultation
    </a>
</div>

<!-- About Section -->
<section style="padding: 60px 0; background-color: #f8f8f8;">
    <div class="container" style="display: flex; flex-wrap: wrap; align-items: center;">
        <div style="flex: 1; padding: 20px;">
            <img src="~/Content/images/law-books.jpg" alt="Law Books" style="width: 100%; border-radius: 8px;" />
        </div>
        <div style="flex: 1; padding: 20px;">
            <h2>About <span style="color: #7c5c3b;">Ampersand Legal</span></h2>
            <p>
                With decades of experience, our firm has successfully represented thousands of clients in complex legal matters.
                We are committed to providing strategic and results-driven legal solutions.
            </p>
            <a href="@Url.Action("About", "Home")" class="btn btn-dark" style="margin-top: 15px;">Learn More</a>
        </div>
    </div>
</section>

<!-- Practice Areas -->
<section style="padding: 60px 0; background-color: white;">
    <div class="container">
        <h2 style="text-align: center; margin-bottom: 40px;">Our Practice Areas</h2>

        <div style="display: flex; flex-wrap: wrap; gap: 20px; justify-content: space-between;">

            <!-- Civil Law -->
            <div style="flex: 1 1 22%; min-width: 220px; text-align: center;">
                <img src="~/Content/images/family-law.jpg" alt="Family Law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px;">Civil Law</h4>
                <p style="font-size: 14px;">Helping families navigate disputes and protect civil rights.</p>
            </div>

            <!-- Corporate Law -->
            <div style="flex: 1 1 22%; min-width: 220px; text-align: center;">
                <img src="~/Content/images/business-law.jpg" alt="Corporate Law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px;">Corporate Law</h4>
                <p style="font-size: 14px;">Business compliance, contracts, and advisory services.</p>
            </div>

            <!-- Criminal Law -->
            <div style="flex: 1 1 22%; min-width: 220px; text-align: center;">
                <img src="~/Content/images/criminal-defence.jpg" alt="Criminal Law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px;">Criminal Law</h4>
                <p style="font-size: 14px;">Defending clients in criminal trials and investigations.</p>
            </div>

            <!-- Cross-Border Advisory -->
            <div style="flex: 1 1 22%; min-width: 220px; text-align: center;">
                <img src="~/Content/Images/Cross-Border.jpg" alt="Cross Border" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px;">Cross-Border</h4>
                <p style="font-size: 14px;">Expertise in international law, transactions, and disputes.</p>
            </div>

        </div>
    </div>
</section>


<!-- Footer Link -->
<div style="text-align: center; font-size: 14px; color: #888; padding: 20px;">
    &copy; @DateTime.Now.Year Ampersand Legal &nbsp;|&nbsp; ampersandlegal.in
</div>

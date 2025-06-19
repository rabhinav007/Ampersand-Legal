@Code
    ViewData("Title") = "home"
End Code

<!-- hero section -->
<div style="background-color: #f4f1ea; color: #3b3b3b; padding: 70px 0 60px 0; text-align: center; font-family: 'Georgia', serif;">
    <h1 style="font-size: 58px; font-weight: 700;">Welcome to Ampersand Legal</h1>
    <p style="font-size: 20px; font-style: italic; text-decoration: underline; color: #59554c;">advocates since 1970</p>
    <h6 style="margin-top: 10px; color: #4b433f;">
        Etymologically derived from the Latin word “et” meaning “and,” Ampersand is a distortion of its original usage, i.e. “and per se and.” Over the years, the conjunctive punctuation has undergone many iterations and is now commonly used in its present form as “&.”
        Deriving its meaning from the same, Ampersand Legal strives at synchronising and bridging the gap between the client’s expectations and their requirements along with aligning and balancing things amidst the process.
    </h6>

</div>

<!-- about section -->
<section style="padding: 60px 0; background-color: #f1edea;">
    <div class="container" style="display: flex; flex-wrap: wrap; align-items: center; gap: 30px;">
        <!-- Image Column -->
        @*<div style="flex: 1; padding: 10px;">
            <img src="~/Content/images/Logo1.jpg" alt="law books" style="width: 100%; border-radius: 8px; box-shadow: 0 4px 15px rgba(0, 0, 0, 0.08);" />
        </div>*@

        <!-- Text Column -->
        <div style="flex: 1; padding: 10px;">
            <h2 style="font-size: 28px; font-weight: 600; margin-bottom: 15px;">
                <span style="color: #a68a64; font-family: 'Yeseva One', serif;">About Ampersand Legal</span>
            </h2>
            <p style="color: #3f3f3f; font-size: 16px; line-height: 1.7;">
                With decades of experience, our firm has successfully represented thousands of clients in complex legal matters.<br />
                We are committed to providing strategic and results-driven legal solutions.
            </p>
            <a href="@Url.Action("About", "Home")" class="btn" style="margin-top: 20px; margin-right: 15px; padding: 10px 24px; background-color: #a68a64; color: white; border: none; border-radius: 4px;">
                Learn More
            </a>
            <a href="@Url.Action("Index", "Contact")" class="btn" style="margin-top: 20px; padding: 10px 25px; background-color: #a68a64; color: white; border: none; border-radius: 4px;">
                Schedule a Consultation
            </a>


        </div>
    </div>
</section>


<!-- practice areas -->
<section style="padding: 50px 0; background-color: #f4f1ea;">
    <div class="container">
        <h2 style="text-align: center; margin-bottom: 40px; color: #2c2c2c;">our practice areas</h2>

        <div style="display: flex; flex-wrap: wrap; gap: 20px; justify-content: space-between;">

            <!-- civil law -->
            <div class="practice-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">

                @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
                <img src="~/Content/images/family-law.jpg" alt="family law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px; color: #4b433f;">civil law</h4>
                <p style="font-size: 14px; color: #59554c;">Helping families navigate disputes and protect civil rights.</p>
            </div>

            <!-- corporate law -->
            <div class="practice-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">

                @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
                <img src="~/Content/images/business-law.jpg" alt="corporate law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px; color: #4b433f;">corporate law</h4>
                <p style="font-size: 14px; color: #59554c;">Business Compliance, Contracts, and Advisory services.</p>
            </div>

            <!-- criminal law -->
            <div class="practice-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">

                @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
                <img src="~/Content/images/criminal-defence.jpg" alt="criminal law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px; color: #4b433f;">criminal law</h4>
                <p style="font-size: 14px; color: #59554c;">Defending clients in Criminal trials and Investigations.</p>
            </div>

            <!-- cross-border -->
            <div class="practice-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">

                @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
                <img src="~/Content/images/Cross-Border.jpg" alt="cross border" style="width: 100%; max-width: 200px; border-radius: 6px;" />
                <h4 style="margin-top: 15px; color: #4b433f;">cross-border</h4>
                <p style="font-size: 14px; color: #59554c;">Expertise in International law, Transactions, and Disputes.</p>
            </div>

        </div>
    </div>
</section>

<!-- footer -->
<!--<div style="text-align: center; font-size: 14px; color: #59554c; padding: 25px; background-color: #e0ddd3; font-family: 'Georgia', serif;">
    &copy; @DateTime.Now.Year ampersand legal &nbsp;|&nbsp; ampersandlegal.in
</div>-->

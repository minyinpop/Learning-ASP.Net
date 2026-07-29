const confirmButton = document.getElementById("confirmButton");
const registerPageButton = document.getElementById("registerPageButton");

confirmButton.addEventListener("click", OnClickConfirmButton);
registerPageButton.addEventListener("click", OnClickRegisterPageButton);

async function OnClickConfirmButton()
{
    const response = await fetch("/Login/Test",
        {
            method: "POST"
        });
    
    await response.json();
    
    console.log(response.message);
}

async function OnClickRegisterPageButton()
{
    window.location.href = "/Register";
}
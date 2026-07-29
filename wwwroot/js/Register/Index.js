const emailInput = document.getElementById("email");
const usernameInput = document.getElementById("username");
const passwordInput = document.getElementById("password");
const confirmPasswordInput = document.getElementById("confirmPassword");

const confirmButton = document.getElementById("confirmButton");
const loginPageButton = document.getElementById("loginPageButton");

confirmButton.addEventListener("click", OnClickConfirmButton);
loginPageButton.addEventListener("click", OnClickLoginPageButton);

async function OnClickConfirmButton()
{
    if (emailInput.value.includes("@") && emailInput.value.includes(".com"))
    {
    }
    else
    {
        console.log("請輸入正確的電子信箱格式");
    }
}

async function OnClickLoginPageButton()
{
    window.location.href = "/Login";
}
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
    if (!CheckEmail())
    {
        return;
    }
    
    if (!CheckUsername())
    {
        return;
    }
    
    function CheckEmail()
    {
        if (emailInput.value.trim() === "")
        {
            alert("電子信箱不得為空！");
            return false;
        }
        
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        
        if (!emailRegex.test(emailInput.value))
        {
            alert("請輸入正確的電子信箱格式！");
            return false;
        }
        
        return true;
    }
    
    function CheckUsername()
    {
        if (usernameInput.value.trim() === "")
        {
            alert("帳號不得為空！");
            return false;
        }
        
        const usernameRegex = /^[A-Za-z0-9]+$/;
        
        if (!usernameRegex.test(usernameInput.value))
        {
            alert("帳號只能包含英文跟數字！");
            return false;
        }
        
        return true;
    }
}

async function OnClickLoginPageButton()
{
    window.location.href = "/Login";
}
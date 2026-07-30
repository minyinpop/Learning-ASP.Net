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
    
    if (!CheckPassword())
    {
        return;
    }
    
    if (!CheckConfirmPassword())
    {
        return;
    }
    
    const fetchSettings = {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            email: emailInput.value,
            username: usernameInput.value,
            password: passwordInput.value,
            confirmPassword: confirmPasswordInput.value
        })
    }
    
    const response = await fetch("/Register/TryRegister", fetchSettings);
    
    // ===
    
    function CheckEmail()
    {
        if (!CheckInputEmpty(emailInput, "電子信箱不得為空！"))
        {
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
        if (!CheckInputEmpty(usernameInput, "帳號不得為空！"))
        {
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
    
    function CheckPassword()
    {
        return CheckInputEmpty(passwordInput, "密碼不得為空！");
    }
    
    function CheckConfirmPassword()
    {
        if (passwordInput.value.trim() !== confirmPasswordInput.value.trim())
        {
            alert("確認密碼與密碼不一致！");
            return false;
        }
        
        return true;
    }
}

async function OnClickLoginPageButton()
{
    window.location.href = "/Login";
}

function CheckInputEmpty(inputElement, alertMessage)
{
    if (inputElement.value.trim() === "")
    {
        alert(alertMessage);
        return false;
    }
    
    return true;
}
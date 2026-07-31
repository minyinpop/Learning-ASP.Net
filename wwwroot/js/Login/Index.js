const emailInput = document.getElementById("email");
const passwordInput = document.getElementById("password");

const confirmButton = document.getElementById("confirmButton");
const registerPageButton = document.getElementById("registerPageButton");

confirmButton.addEventListener("click", OnClickConfirmButton);
registerPageButton.addEventListener("click", OnClickRegisterPageButton);

async function OnClickConfirmButton()
{
    if (!await CheckEmail())
    {
        return;
    }
    
    if (!CheckPassword())
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
            password: passwordInput.value
        })
    }
    
    const response = await fetch("/Login/TryLogin", fetchSettings);
    
    const json = await response.json();
    
    alert(json.message);
}

async function OnClickRegisterPageButton()
{
    window.location.href = "/Register";
}

async function CheckEmail()
{
    if (CheckInputEmpty(emailInput, "電子信箱不得為空！"))
    {
        return false;
    }

    const response = await fetch("/Register/GetRegisterRules");

    const rules = await response.json();

    const emailRegex = new RegExp(rules.email);

    if (!emailRegex.test(emailInput.value))
    {
        alert("請輸入正確的電子信箱格式！");
        return false;
    }

    return true;
}

function CheckPassword()
{
    if (CheckInputEmpty(passwordInput, "密碼不得為空！"))
    {
        return false;
    }
    
    return true;
}

function CheckInputEmpty(inputElement, alertMessage)
{
    if (inputElement.value.trim() === "")
    {
        alert(alertMessage);
        return true;
    }
    
    return false;
}
const username = document.getElementById("username");
const password = document.getElementById("password");
const loginButton = document.getElementById("loginButton");

loginButton.addEventListener("click", onClickLoginButton);

async function onClickLoginButton()
{
    const response = await fetch("/Login/Test",
        {
            method: "POST"
        });
    
    await response.json();
    
    console.log(response.message);
}
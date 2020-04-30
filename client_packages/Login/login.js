$('#loginBtn').click(() => {
	mp.trigger('loginToServer', $('#usernameTxt').val(), $('#passwordTxt').val());
});

$('#registerButton').click(() => {
	mp.trigger('registerToServer', $('#registerUsernameText').val(), $('#registerPasswordText').val());
});

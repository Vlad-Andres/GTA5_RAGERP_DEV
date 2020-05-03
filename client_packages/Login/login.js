$('#loginBtn').click(() => {
	mp.trigger('loginToServer', $('#usernameTxt').val(), $('#passwordTxt').val());
});

$('#registerBtn').click(() => {
	mp.trigger('registerToServer', $('#usernameTxt').val(), $('#passwordTxt').val(), $('#emailTxt').val());
});

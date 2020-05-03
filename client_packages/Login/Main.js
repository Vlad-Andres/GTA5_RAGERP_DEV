// example of func that can be called from C#
// mp.events.add('showLoginBrowser', () => {
// 	let loginBrowser = mp.browsers.new('package://Login/index.html');
// 	mp.gui.cursor.show(true, true);
// });

mp.events.add('loginToServer', (username, password) => {
	mp.events.callRemote('OnPlayerLoginAttempt', username, password);
});

mp.events.add('registerToServer', (username, password, email) => {
	mp.events.callRemote('OnPlayerRegisterAttempt', username, password, email);
});

mp.events.add('LoginResult', (result) => {
	if (result == 1) {
		//Success we destroy the loginBrowser as we don't need it anymore
		loginBrowser.destroy();
		mp.gui.cursor.show(false, false);

		mp.gui.chat.push('You have successfully logged in.');
	} else {
		//Failed we just send a message to the player saying he provided incorrect info
		//Here you can be creative and handle it visually in your webpage by using the (browser).execute or loginBrowser.execute in our case to execute a js code in your webpage

		mp.gui.chat.push('Incorrect password or username.');
	}
});

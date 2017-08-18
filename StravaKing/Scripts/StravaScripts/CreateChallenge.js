angular.module('datepickerBasicUsage', ['ngMaterial', 'ngMessages']).controller('createChallengeCtrl', function () {
	this.myDate = new Date();
	this.isOpen = false;
});
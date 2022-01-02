// Get day number

let days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

let parseDay = searchedDay => {
	let dayNumber = days.findIndex(val => 
  	searchedDay.startsWith(val.toLowerCase())) + 1;
	return dayNumber === 0 ? -1 : dayNumber;
};
  


const result = parseDay('friday');
console.log(result);

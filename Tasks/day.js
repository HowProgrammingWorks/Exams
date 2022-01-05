// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = searchedDay => {
  const dayIndex = days.findIndex(val =>
    searchedDay.startsWith(val.toLowerCase()));
  const dayNumber = dayIndex + 1;
  return dayNumber === 0 ? -1 : dayNumber;
};



const result = parseDay('friday');
console.log(result);

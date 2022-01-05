'use strict'

// Get day number

const week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const dayNumber = (day) =>{
  for(let i=0; i<week.length; i++){
    const dayLowerCase =day.toLowerCase();
    if(dayLowerCase.startsWith(week[i].toLowerCase())){
      return ++i;
    };
  };
  return -1;
};


console.log(`friday    - ${dayNumber('friday')}`);
console.log(`Friday    - ${dayNumber('Friday')}`);
console.log(`Mon       - ${dayNumber('Mon')}`);
console.log(`monday    - ${dayNumber('monday')}`);
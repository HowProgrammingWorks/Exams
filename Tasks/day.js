'use strict'

// Get day number

let week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

const dayNumber = day =>{
  let i; for(i=0;i<week.length;i++){
  if(day.startsWith(week[i].toLowerCase())){return i +1};};return -1;
};

const result = dayNumber('friday')
console.log(result)

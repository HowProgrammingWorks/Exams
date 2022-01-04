// Get day number
'use strict'
const parseDay = day => {
  
  for(let i = 0; i < days.length; i++){
  if(s.startsWith(days[i].toLowerCase())){return i + 1};};
};
const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
const result = parseDay('friday')
console.log(result)

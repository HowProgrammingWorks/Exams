// Get day number
'use strict';
const parseDay = (day) => {
  for (let i = 0; i < days.length; i++) {
    const daysPrefixes = days[i].toLowerCase()
  if (day.startsWith(daysPrefixes))
    return i + 1;
  }
};
const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
const result = parseDay('friday')
console.log(result)


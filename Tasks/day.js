// Get day number

const weekDays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = day => {
  for (let i = 0; i < weekDays.length; i++) {
    if (day.startsWith(weekDays[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

const result = parseDay('friday');
console.log(result);

// Get day number

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (s) => {
  let index;
  for (index = 0; index < days.length; index++) {
    if (s.startsWith(days[index].toLowerCase())) {
      return index + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);

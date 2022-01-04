// Get day number

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

function parser(day) {
  for (let i = 0; i < days.length; i++) {
    if (day.startsWith(days[i].toLowerCase())) {
      return `match found: ${i+1}`
    };
  };
  return `no match: ${-1}`;
};

const result = parser('friday')
console.log(result)

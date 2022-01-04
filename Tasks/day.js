// Get day number

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

const parser = s => {
  for (let i = 0; i < days.length; i++) {
    if (s.startsWith(days[i].toLowerCase())) {
      return i + 1
    };
  };
  return -1;
};

const result = parser('friday')
console.log(result)

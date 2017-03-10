var component_graph = new Vue({
  el: '#prediccion',
  data: {
    futures: [],
    text: ''
  },
  mounted: function () {},
  methods: {},
  watch: {
    text: function (val, oldVal) {
      if (val.trim() != oldVal.trim() && val.trim() != "") {
        var vm = this;
        // console.log("Hola", val)
        vm.futures = []
        axios.get('/markov/api/' + val).then(function (response) {
            Object.keys(response.data.probabilidad).forEach(function (key) {
              console.log(key + ': ' + response.data.probabilidad[key]);
              vm.futures.push({
                index: key,
                value: {
                  word: response.data.probabilidad[key][0],
                  prob: response.data.probabilidad[key][1]
                }
              })
            });
            // console.log(vm.futures);
          })
          .catch(function (error) {
            console.log(error);
          });
      }
    }
  }
})
var component_graph = new Vue({
  el: '#component_graph',
  data: {
    selectedto: 1,
    selectedfrom: 1,
    estados: [{
      id: 1,
      label: 'Estado 1',
      title: 'I have a popup!'
    }],
    seguir: false,
    edges: [],
    count: 1,
    probabilidad: 0.0
  },
  mounted: function () {
    // this.graph()
    console.log('created', this);
    var vm = this;
    vm.$root.selectedto = 1;
  },
  methods: {
    addState: function (event) { // Añade un estado
      this.estados.push({
        id: ++this.count,
        label: '',
        title: 'Estado ' + this.count
      });
      return this.estados
    },
    addEdge: function (event) { // Añade un estado
      console.log("=>", this.selectedto, this.selectedfrom)
      if (this.selectedto && this.selectedfrom) {
        this.edges.push({
          to: this.selectedto,
          from: this.selectedfrom,
          label: this.probabilidad
        });
      } else {
        alert("Debe seleccionar los dos estados de transición")
      }
      // this.selectedto = 1;
      // this.selectedfrom = 1;
      return this.edges
    },
    removeLast: function (event) { // Quita el ultimo estado ingresado
      this.estados.pop();
    },
    reverse: function (event) { // Invierte la lista de estados
      this.estados = this.estados.reverse();
    },
    continuar: function (event) {
      this.seguir = true;

      this.graph()
    },
    graph: function () {
      var container = document.getElementById('mynetwork');
      var data1 = {
        nodes: this.estados,
        edges: this.edges
      };
      var options = {
        interaction: {
          hover: true
        }
      };
      var network = new vis.Network(container, data1, options);
      console.log("Data", network)
    }
  }
})

// component_graph.selectedto = 0;
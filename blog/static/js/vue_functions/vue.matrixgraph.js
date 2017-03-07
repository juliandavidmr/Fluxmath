var component_graph = new Vue({
  el: '#component_graph',
  data: {
    estados: [{
      id: 1,
      label: 'Estado 1',
      title: 'I have a popup!'
    }],
    seguir: false,
    nodes: [{
        id: 1,
        label: 'Node 1',
        title: 'I have a popup!'
      },
      {
        id: 2,
        label: 'Node 2',
        title: 'I have a popup!'
      },
      {
        id: 3,
        label: 'Node 3',
        title: 'I have a popup!'
      },
      {
        id: 4,
        label: 'Node 4',
        title: 'I have a popup!'
      },
      {
        id: 5,
        label: 'Node 5',
        title: 'I have a popup!'
      }
    ],
    edges: [
      {
        from: 1,
        to: 3
      },
      {
        from: 1,
        to: 2
      },
      {
        from: 2,
        to: 4
      },
      {
        from: 2,
        to: 5
      }
    ],
    count: 1
  },
  mounted: function () {
    // this.graph()
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
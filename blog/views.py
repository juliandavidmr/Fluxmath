from django.shortcuts import render, get_object_or_404
from django.utils import timezone
from .models import Publicacion
from .forms import PublicacionForm

from .markov import *

# Create your views here.


def publicacion_list(request):
    publicaciones = Publicacion.objects.order_by('publicado_fecha')
    return render(request, 'blog/publicacion_list.html', {'publicaciones': publicaciones})


def publicacion_detalle(request, pk):
    publicacion = get_object_or_404(Publicacion, pk=pk)
    return render(request, 'blog/publicacion_detalle.html', {'publicacion': publicacion})


def publicacion_crear(request):
    if request.method == "POST":
        form = PublicacionForm(request.POST)
    else:
        form = PublicacionForm()
    return render(request, 'blog/publicacion_crear.html', {'form': form})


def markov_steps(request):
    if request.method == "POST":
        inp = request.POST.get('matrix', '')  # => [137]
        ste = request.POST.get('steps', '')  # => [137]
        matrix_input = stringToMatrix(input_str=inp)
        result = nextSteps(matrix_input, steps=int(ste))
        return render(request, 'blog/markov_steps.html', {'result': result})
    else:
        return render(request, 'blog/markov_steps.html', {})


def markov_graph_matrix(request):
    return render(request, 'blog/markov_graph_matrix.html', {})
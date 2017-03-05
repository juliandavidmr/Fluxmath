from django.shortcuts import render

# Create your views here.

def publicacion_list(request):
    return render(request, 'blog/publicacion_list.html', {})
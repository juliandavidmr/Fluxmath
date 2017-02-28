# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
from django.conf import settings
import django.utils.timezone


class Migration(migrations.Migration):

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
    ]

    operations = [
        migrations.CreateModel(
            name='Publicacion',
            fields=[
                ('id', models.AutoField(auto_created=True, serialize=False, primary_key=True, verbose_name='ID')),
                ('titulo', models.CharField(max_length=200)),
                ('texto', models.TextField()),
                ('creacion_fecha', models.DateTimeField(default=django.utils.timezone.now)),
                ('publicado_fecha', models.DateTimeField(blank=True, null=True)),
                ('autor', models.ForeignKey(to=settings.AUTH_USER_MODEL)),
            ],
        ),
    ]
